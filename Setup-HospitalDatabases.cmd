@echo off
setlocal

set "SCRIPT_DIR=%~dp0"
set "SQL_SETUP_SCRIPT=%SCRIPT_DIR%SQL setup files\HospitalManagementDB_SQL_Setup.sql"
set "SQL_DEMO_SCRIPT=%SCRIPT_DIR%SQL setup files\HospitalManagementDB_SQL_Populate_Demo.sql"
set "MONGO_DEMO_SCRIPT=%SCRIPT_DIR%SQL setup files\HospitalManagementDB_Mongo_Populate_Demo.js"

set "SQL_SERVER=casper.local"
set "SQL_DATABASE=HospitalManagementDB_SQL"
set "SQL_USER=sa"
set "SQL_PASSWORD=ChangeMe!"
set "MONGO_CONNECTION_STRING=mongodb://192.168.1.206:27017/HospitalManagementDB"
set "MONGO_DATABASE=HospitalManagementDB"

:Menu
cls
echo Hospital Database Setup
echo =======================
call :ShowSettings
echo.
echo 1. Reset SQL and MongoDB
echo 2. Setup SQL schema
echo 3. Populate SQL and MongoDB demo data
echo 4. Full reset + setup + demo data
echo 5. Edit connection settings
echo 6. Exit
echo.
set "MENU_CHOICE="
set /p "MENU_CHOICE=Pick an option: "

if "%MENU_CHOICE%"=="1" (
    echo.
    call :ResetDatabases
    call :ShowActionResult
    goto Menu
)
if "%MENU_CHOICE%"=="2" (
    echo.
    call :SetupSqlDatabase
    call :ShowActionResult
    goto Menu
)
if "%MENU_CHOICE%"=="3" (
    echo.
    call :PopulateDemoData
    call :ShowActionResult
    goto Menu
)
if "%MENU_CHOICE%"=="4" (
    echo.
    call :FullSetup
    call :ShowActionResult
    goto Menu
)
if "%MENU_CHOICE%"=="5" call :EditSettings
if "%MENU_CHOICE%"=="6" goto End
if "%MENU_CHOICE%"=="" goto End

if not "%MENU_CHOICE%"=="1" if not "%MENU_CHOICE%"=="2" if not "%MENU_CHOICE%"=="3" if not "%MENU_CHOICE%"=="4" if not "%MENU_CHOICE%"=="5" if not "%MENU_CHOICE%"=="6" (
    echo.
    echo Unknown option. Choose 1 through 6.
    call :WaitForEnter
)
goto Menu

:ShowActionResult
if errorlevel 1 (
    echo.
    echo The selected action failed.
) else (
    echo.
    echo Done.
)
call :WaitForEnter
exit /b 0

:ShowSettings
echo Current settings
echo SQL Server:      %SQL_SERVER%
echo SQL Database:    %SQL_DATABASE%
if "%SQL_USER%"=="" (
    echo SQL Auth:        Windows authentication
) else (
    echo SQL Auth:        SQL user '%SQL_USER%'
)
echo Mongo Database:  %MONGO_DATABASE%
echo Mongo URI:       %MONGO_CONNECTION_STRING%
exit /b 0

:WaitForEnter
echo.
pause >nul
exit /b 0

:RequireCommand
where "%~1" >nul 2>nul
if errorlevel 1 (
    echo Error: '%~1' was not found. %~2
    exit /b 1
)
exit /b 0

:BuildSqlAuthArgs
if "%SQL_USER%"=="" (
    set "SQL_AUTH_ARGS=-E"
) else (
    set SQL_AUTH_ARGS=-U "%SQL_USER%" -P "%SQL_PASSWORD%"
)
exit /b 0

:ResetDatabases
call :ResetSqlDatabase
if errorlevel 1 exit /b 1
call :ResetMongoDatabase
if errorlevel 1 exit /b 1
exit /b 0

:SetupSqlDatabase
if not exist "%SQL_SETUP_SCRIPT%" (
    echo Error: SQL setup script was not found: %SQL_SETUP_SCRIPT%
    exit /b 1
)

call :RequireCommand sqlcmd "Install Microsoft sqlcmd or run this script on the SQL Server VM where sqlcmd is available."
if errorlevel 1 exit /b 1

echo Setting up SQL schema in '%SQL_DATABASE%'...
call :BuildSqlAuthArgs
sqlcmd -S "%SQL_SERVER%" -d master -b %SQL_AUTH_ARGS% -v DatabaseName="%SQL_DATABASE%" -i "%SQL_SETUP_SCRIPT%"
if errorlevel 1 (
    echo Error: sqlcmd failed while setting up the SQL schema.
    exit /b 1
)

echo SQL schema setup complete.
exit /b 0

:PopulateDemoData
call :PopulateSqlDemoData
if errorlevel 1 exit /b 1
call :PopulateMongoDemoData
if errorlevel 1 exit /b 1
exit /b 0

:FullSetup
call :ResetDatabases
if errorlevel 1 exit /b 1
call :SetupSqlDatabase
if errorlevel 1 exit /b 1
call :PopulateDemoData
if errorlevel 1 exit /b 1
exit /b 0

:ResetSqlDatabase
call :RequireCommand sqlcmd "Install Microsoft sqlcmd or run this script on the SQL Server VM where sqlcmd is available."
if errorlevel 1 exit /b 1

echo Resetting SQL database '%SQL_DATABASE%' on '%SQL_SERVER%'...
call :BuildSqlAuthArgs
sqlcmd -S "%SQL_SERVER%" -d master -b %SQL_AUTH_ARGS% -Q "DECLARE @DatabaseName sysname = N'%SQL_DATABASE%'; IF DB_ID(@DatabaseName) IS NOT NULL BEGIN DECLARE @Sql nvarchar(max); SET @Sql = N'ALTER DATABASE ' + QUOTENAME(@DatabaseName) + N' SET SINGLE_USER WITH ROLLBACK IMMEDIATE;'; EXEC(@Sql); SET @Sql = N'DROP DATABASE ' + QUOTENAME(@DatabaseName) + N';'; EXEC(@Sql); END;"
if errorlevel 1 (
    echo Error: sqlcmd failed while resetting the SQL database.
    exit /b 1
)

echo SQL database reset complete. Run setup before loading or using data.
exit /b 0

:PopulateSqlDemoData
if not exist "%SQL_DEMO_SCRIPT%" (
    echo Error: SQL demo script was not found: %SQL_DEMO_SCRIPT%
    exit /b 1
)

call :RequireCommand sqlcmd "Install Microsoft sqlcmd or run this script on the SQL Server VM where sqlcmd is available."
if errorlevel 1 exit /b 1

echo Loading SQL demo data into '%SQL_DATABASE%'...
call :BuildSqlAuthArgs
sqlcmd -S "%SQL_SERVER%" -d master -b %SQL_AUTH_ARGS% -v DatabaseName="%SQL_DATABASE%" -i "%SQL_DEMO_SCRIPT%"
if errorlevel 1 (
    echo Error: sqlcmd failed while loading SQL demo data.
    exit /b 1
)

echo SQL demo data loaded.
exit /b 0

:ResetMongoDatabase
call :RequireCommand mongosh "Install MongoDB Shell from https://www.mongodb.com/try/download/shell."
if errorlevel 1 exit /b 1

echo Resetting MongoDB database '%MONGO_DATABASE%'...
mongosh "%MONGO_CONNECTION_STRING%" --quiet --eval "db.getSiblingDB('%MONGO_DATABASE%').dropDatabase();"
if errorlevel 1 (
    echo Error: mongosh failed while resetting MongoDB.
    exit /b 1
)

echo MongoDB database reset complete.
exit /b 0

:PopulateMongoDemoData
if not exist "%MONGO_DEMO_SCRIPT%" (
    echo Error: MongoDB demo script was not found: %MONGO_DEMO_SCRIPT%
    exit /b 1
)

call :RequireCommand mongosh "Install MongoDB Shell from https://www.mongodb.com/try/download/shell."
if errorlevel 1 exit /b 1

echo Loading MongoDB demo accounts into '%MONGO_DATABASE%'...
set "HOSPITAL_MONGO_DATABASE=%MONGO_DATABASE%"
mongosh "%MONGO_CONNECTION_STRING%" --quiet --file "%MONGO_DEMO_SCRIPT%"
if errorlevel 1 (
    echo Error: mongosh failed while loading MongoDB demo accounts.
    exit /b 1
)

echo MongoDB demo accounts loaded.
exit /b 0

:EditSettings
cls
echo Edit Connection Settings
echo Leave a value blank to keep the current setting.
echo.

set "NEW_VALUE="
set /p "NEW_VALUE=SQL Server [%SQL_SERVER%]: "
if not "%NEW_VALUE%"=="" set "SQL_SERVER=%NEW_VALUE%"

set "NEW_VALUE="
set /p "NEW_VALUE=SQL Database [%SQL_DATABASE%]: "
if not "%NEW_VALUE%"=="" set "SQL_DATABASE=%NEW_VALUE%"

if "%SQL_USER%"=="" (
    set "CURRENT_SQL_USER=Windows authentication"
) else (
    set "CURRENT_SQL_USER=%SQL_USER%"
)
set "NEW_VALUE="
set /p "NEW_VALUE=SQL User, or WINDOWS for Windows authentication [%CURRENT_SQL_USER%]: "
if /i "%NEW_VALUE%"=="WINDOWS" (
    set "SQL_USER="
    set "SQL_PASSWORD="
) else (
    if not "%NEW_VALUE%"=="" set "SQL_USER=%NEW_VALUE%"
)

if not "%SQL_USER%"=="" (
    set "NEW_VALUE="
    set /p "NEW_VALUE=SQL Password [blank keeps current value]: "
    if not "%NEW_VALUE%"=="" set "SQL_PASSWORD=%NEW_VALUE%"
)

set "NEW_VALUE="
set /p "NEW_VALUE=Mongo connection string [%MONGO_CONNECTION_STRING%]: "
if not "%NEW_VALUE%"=="" set "MONGO_CONNECTION_STRING=%NEW_VALUE%"

set "NEW_VALUE="
set /p "NEW_VALUE=Mongo database [%MONGO_DATABASE%]: "
if not "%NEW_VALUE%"=="" set "MONGO_DATABASE=%NEW_VALUE%"

echo.
echo Connection settings updated for this script run.
call :WaitForEnter
exit /b 0

:End
endlocal
