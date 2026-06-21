@echo off
setlocal

set "SCRIPT_DIR=%~dp0"
set "SQL_SETUP_SCRIPT=%SCRIPT_DIR%SQL setup files\HospitalManagementDB_SQL_Setup.sql"
set "SQL_DEMO_SCRIPT=%SCRIPT_DIR%SQL setup files\HospitalManagementDB_SQL_Populate_Demo.sql"
set "MONGO_DEMO_SCRIPT=%SCRIPT_DIR%SQL setup files\HospitalManagementDB_Mongo_Populate_Demo.js"
set "APP_SETTINGS=%SCRIPT_DIR%appsettings.json"
set "HOSPITAL_APP_SETTINGS=%APP_SETTINGS%"

call :LoadSettings
if errorlevel 1 goto End

:Menu
cls
echo Hospital Database Setup
echo =======================
call :ShowSettings
echo.
echo 1. Reset SQL and MongoDB
echo 2. Setup SQL schema
echo 3. Populate SQL and MongoDB demo data
echo Q. Exit
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
if /i "%MENU_CHOICE%"=="Q" goto End
if "%MENU_CHOICE%"=="" goto End

if not "%MENU_CHOICE%"=="1" if not "%MENU_CHOICE%"=="2" if not "%MENU_CHOICE%"=="3" (
    echo.
    echo Unknown option. Choose 1, 2, 3, or Q.
    call :WaitForEnter
)
goto Menu

:LoadSettings
if not exist "%APP_SETTINGS%" (
    echo Error: appsettings.json was not found: %APP_SETTINGS%
    exit /b 1
)

call :RequireCommand powershell "Install Windows PowerShell or run this script on a Windows machine that includes it."
if errorlevel 1 exit /b 1

set "CONFIG_OUTPUT=%TEMP%\hospital-config-%RANDOM%-%RANDOM%.tmp"
powershell -NoProfile -ExecutionPolicy Bypass -Command "$ErrorActionPreference = 'Stop'; $config = Get-Content -Raw -Path $env:HOSPITAL_APP_SETTINGS | ConvertFrom-Json; $sqlConnection = $config.ConnectionStrings.HospitalSqlConnection; if ([string]::IsNullOrWhiteSpace($sqlConnection)) { throw 'ConnectionStrings:HospitalSqlConnection is required.' }; $sql = New-Object -TypeName System.Data.SqlClient.SqlConnectionStringBuilder -ArgumentList $sqlConnection; $mongoConnection = $config.ConnectionStrings.MongoConnection; if ([string]::IsNullOrWhiteSpace($mongoConnection)) { $mongoConnection = $config.MongoAccount.ConnectionString }; if ([string]::IsNullOrWhiteSpace($mongoConnection)) { throw 'ConnectionStrings:MongoConnection is required.' }; $mongoDatabase = $config.MongoAccount.DatabaseName; if ([string]::IsNullOrWhiteSpace($mongoDatabase)) { $withoutQuery = $mongoConnection.Split('?')[0]; $lastSlash = $withoutQuery.LastIndexOf('/'); if ($lastSlash -ge 0 -and $lastSlash -lt ($withoutQuery.Length - 1)) { $mongoDatabase = $withoutQuery.Substring($lastSlash + 1) } }; if ([string]::IsNullOrWhiteSpace($mongoDatabase)) { throw 'MongoAccount:DatabaseName is required when the Mongo connection string does not include a database.' }; 'SQL_SERVER=' + $sql.DataSource; 'SQL_DATABASE=' + $sql.InitialCatalog; 'SQL_TRUST_SERVER_CERTIFICATE=' + $sql.TrustServerCertificate; if ($sql.IntegratedSecurity) { 'SQL_USER='; 'SQL_PASSWORD=' } else { 'SQL_USER=' + $sql.UserID; 'SQL_PASSWORD=' + $sql.Password }; 'MONGO_CONNECTION_STRING=' + $mongoConnection; 'MONGO_DATABASE=' + $mongoDatabase" > "%CONFIG_OUTPUT%"
if errorlevel 1 (
    if exist "%CONFIG_OUTPUT%" del "%CONFIG_OUTPUT%" >nul 2>nul
    echo Error: Could not read connection settings from appsettings.json.
    exit /b 1
)

for /f "usebackq tokens=1,* delims==" %%A in ("%CONFIG_OUTPUT%") do set "%%A=%%B"
del "%CONFIG_OUTPUT%" >nul 2>nul
exit /b 0

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
echo SQL Trust Cert:  %SQL_TRUST_SERVER_CERTIFICATE%
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

:BuildSqlcmdArgs
call :BuildSqlAuthArgs
set "SQL_CERT_ARGS="
if /i "%SQL_TRUST_SERVER_CERTIFICATE%"=="True" set "SQL_CERT_ARGS=-C"
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
call :BuildSqlcmdArgs
sqlcmd -S "%SQL_SERVER%" -d master -b %SQL_AUTH_ARGS% %SQL_CERT_ARGS% -v DatabaseName="%SQL_DATABASE%" -i "%SQL_SETUP_SCRIPT%"
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

:ResetSqlDatabase
call :RequireCommand sqlcmd "Install Microsoft sqlcmd or run this script on the SQL Server VM where sqlcmd is available."
if errorlevel 1 exit /b 1

echo Resetting SQL database '%SQL_DATABASE%' on '%SQL_SERVER%'...
call :BuildSqlcmdArgs
sqlcmd -S "%SQL_SERVER%" -d master -b %SQL_AUTH_ARGS% %SQL_CERT_ARGS% -Q "DECLARE @DatabaseName sysname = N'%SQL_DATABASE%'; IF DB_ID(@DatabaseName) IS NOT NULL BEGIN DECLARE @Sql nvarchar(max); SET @Sql = N'ALTER DATABASE ' + QUOTENAME(@DatabaseName) + N' SET SINGLE_USER WITH ROLLBACK IMMEDIATE;'; EXEC(@Sql); SET @Sql = N'DROP DATABASE ' + QUOTENAME(@DatabaseName) + N';'; EXEC(@Sql); END;"
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
call :BuildSqlcmdArgs
sqlcmd -S "%SQL_SERVER%" -d master -b %SQL_AUTH_ARGS% %SQL_CERT_ARGS% -v DatabaseName="%SQL_DATABASE%" -i "%SQL_DEMO_SCRIPT%"
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

:End
endlocal
