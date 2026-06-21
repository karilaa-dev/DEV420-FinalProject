-- Hospital Management System SQL setup
-- Run this script before using the Hospital Management System.
-- This script creates the schema only. Demo data is loaded by HospitalManagementDB_SQL_Populate_Demo.sql.
-- When run from Setup-HospitalDatabases.cmd, DatabaseName is supplied by the launcher.

IF DB_ID(N'$(DatabaseName)') IS NULL
BEGIN
    CREATE DATABASE [$(DatabaseName)];
END
GO

USE [$(DatabaseName)];
GO

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET NUMERIC_ROUNDABORT OFF;
GO

IF OBJECT_ID('dbo.Patients', 'U') IS NOT NULL
    AND (
        COL_LENGTH('dbo.Patients', 'PatientUserId') IS NULL
        OR COL_LENGTH('dbo.Patients', 'Department') IS NOT NULL
        OR ISNULL(COLUMNPROPERTY(OBJECT_ID(N'dbo.Patients'), N'PatientId', 'IsIdentity'), 0) <> 1
    )
BEGIN
    RAISERROR('Old Patients schema detected. Use Setup-HospitalDatabases.cmd option 1 to reset the SQL database before setup.', 16, 1);
    RETURN;
END
GO

IF (OBJECT_ID('dbo.DoctorProfiles', 'U') IS NOT NULL AND COL_LENGTH('dbo.DoctorProfiles', 'Department') IS NOT NULL)
    OR (OBJECT_ID('dbo.PatientVitals', 'U') IS NOT NULL AND COL_LENGTH('dbo.PatientVitals', 'Room') IS NOT NULL)
    OR OBJECT_ID('dbo.BedStatuses', 'U') IS NOT NULL
BEGIN
    RAISERROR('Old department, room, or bed schema detected. Use Setup-HospitalDatabases.cmd option 1 to reset the SQL database before setup.', 16, 1);
    RETURN;
END
GO

IF OBJECT_ID('dbo.Patients', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Patients
    (
        PatientId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        PatientUserId NVARCHAR(50) NULL,
        Name NVARCHAR(100) NOT NULL,
        Gender NVARCHAR(50) NULL,
        DateOfBirth DATE NULL,
        Phone NVARCHAR(50) NULL,
        IsAdmitted BIT NOT NULL DEFAULT 0,
        Notes NVARCHAR(500) NULL
    );
END
GO

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE object_id = OBJECT_ID(N'dbo.Patients')
        AND name = N'UX_Patients_PatientUserId'
)
BEGIN
    CREATE UNIQUE INDEX UX_Patients_PatientUserId
        ON dbo.Patients(PatientUserId)
        WHERE PatientUserId IS NOT NULL;
END
GO

IF OBJECT_ID('dbo.DoctorProfiles', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.DoctorProfiles
    (
        DoctorProfileId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        UserId NVARCHAR(50) NOT NULL UNIQUE,
        Username NVARCHAR(100) NOT NULL UNIQUE,
        DisplayName NVARCHAR(100) NOT NULL,
        IsActive BIT NOT NULL DEFAULT 1,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        UpdatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME()
    );
END
GO

IF OBJECT_ID('dbo.Appointments', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Appointments
    (
        AppointmentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        PatientId INT NOT NULL,
        DoctorProfileId INT NOT NULL,
        VisitReason NVARCHAR(200) NOT NULL,
        AppointmentDateTime DATETIME2 NOT NULL,
        AppointmentStatus NVARCHAR(50) NOT NULL,
        CompletionMessageSent BIT NOT NULL DEFAULT 0,
        Notes NVARCHAR(500) NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        CONSTRAINT FK_Appointments_Patients
            FOREIGN KEY (PatientId) REFERENCES dbo.Patients(PatientId),
        CONSTRAINT FK_Appointments_DoctorProfiles
            FOREIGN KEY (DoctorProfileId) REFERENCES dbo.DoctorProfiles(DoctorProfileId)
    );
END
GO

IF OBJECT_ID('dbo.InventoryItems', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.InventoryItems
    (
        InventoryItemId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        ItemName NVARCHAR(100) NOT NULL,
        Category NVARCHAR(100) NOT NULL,
        Quantity INT NOT NULL,
        ReorderLevel INT NOT NULL,
        StorageLocation NVARCHAR(100) NULL,
        UpdatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME()
    );
END
GO

IF OBJECT_ID('dbo.InventoryTransactions', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.InventoryTransactions
    (
        InventoryTransactionId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        InventoryItemId INT NULL,
        ItemName NVARCHAR(100) NOT NULL,
        Category NVARCHAR(100) NOT NULL,
        QuantityChange INT NOT NULL,
        TransactionReason NVARCHAR(200) NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        CONSTRAINT FK_InventoryTransactions_InventoryItems
            FOREIGN KEY (InventoryItemId)
            REFERENCES dbo.InventoryItems(InventoryItemId)
            ON DELETE SET NULL
    );
END
GO

IF OBJECT_ID('dbo.ChatConversations', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.ChatConversations
    (
        ChatConversationId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        ConversationName NVARCHAR(100) NOT NULL UNIQUE,
        PatientId INT NOT NULL UNIQUE,
        ConversationType NVARCHAR(50) NOT NULL DEFAULT 'Patient',
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        CONSTRAINT FK_ChatConversations_Patients
            FOREIGN KEY (PatientId) REFERENCES dbo.Patients(PatientId)
    );
END
GO

IF OBJECT_ID('dbo.ChatMessages', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.ChatMessages
    (
        ChatMessageId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        ChatConversationId INT NOT NULL,
        SenderName NVARCHAR(100) NOT NULL,
        SenderRole NVARCHAR(100) NULL,
        MessageText NVARCHAR(1000) NOT NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        CONSTRAINT FK_ChatMessages_ChatConversations
            FOREIGN KEY (ChatConversationId)
            REFERENCES dbo.ChatConversations(ChatConversationId)
    );
END
GO

IF OBJECT_ID('dbo.PatientVitals', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.PatientVitals
    (
        PatientVitalsId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        PatientId INT NOT NULL,
        HeartRate INT NOT NULL,
        BloodPressure NVARCHAR(50) NULL,
        OxygenLevel INT NOT NULL,
        Temperature DECIMAL(5,1) NOT NULL,
        VitalsStatus NVARCHAR(50) NOT NULL,
        Notes NVARCHAR(500) NULL,
        UpdatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        CONSTRAINT FK_PatientVitals_Patients
            FOREIGN KEY (PatientId) REFERENCES dbo.Patients(PatientId)
    );
END
GO

IF OBJECT_ID('dbo.SystemNotifications', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.SystemNotifications
    (
        SystemNotificationId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
        NotificationType NVARCHAR(100) NOT NULL,
        MessageText NVARCHAR(500) NOT NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME()
    );
END
GO

PRINT 'HospitalManagement SQL schema is ready.';
