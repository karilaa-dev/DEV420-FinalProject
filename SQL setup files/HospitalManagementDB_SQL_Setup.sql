-- Hospital Management System SQL setup
-- Run this script before using Patient Management

IF DB_ID('HospitalManagementDB_SQL') IS NULL
BEGIN
    CREATE DATABASE HospitalManagementDB_SQL;
END
GO

USE HospitalManagementDB_SQL;
GO

IF OBJECT_ID('dbo.Patients', 'U') IS NULL
BEGIN
    CREATE TABLE Patients
    (
        PatientId NVARCHAR(50) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Gender NVARCHAR(50),
        DateOfBirth DATE,
        Phone NVARCHAR(50),
        Department NVARCHAR(100),
        IsAdmitted BIT,
        Notes NVARCHAR(500)
    );
END
GO