-- Hospital Management System demo data
-- Run this after HospitalManagementDB_SQL_Setup.sql.
-- When run from Setup-HospitalDatabases.cmd, DatabaseName is supplied by the launcher.

IF DB_ID(N'$(DatabaseName)') IS NULL
BEGIN
    RAISERROR('The SQL database does not exist. Run setup first.', 16, 1);
    RETURN;
END

USE [$(DatabaseName)];

SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET NUMERIC_ROUNDABORT OFF;

IF OBJECT_ID(N'dbo.Patients', N'U') IS NULL
    OR OBJECT_ID(N'dbo.DoctorProfiles', N'U') IS NULL
    OR OBJECT_ID(N'dbo.Appointments', N'U') IS NULL
    OR OBJECT_ID(N'dbo.InventoryItems', N'U') IS NULL
    OR OBJECT_ID(N'dbo.InventoryTransactions', N'U') IS NULL
    OR OBJECT_ID(N'dbo.ChatConversations', N'U') IS NULL
    OR OBJECT_ID(N'dbo.ChatMessages', N'U') IS NULL
    OR OBJECT_ID(N'dbo.PatientVitals', N'U') IS NULL
    OR OBJECT_ID(N'dbo.SystemNotifications', N'U') IS NULL
BEGIN
    RAISERROR('One or more required tables are missing. Run a reset or setup script first.', 16, 1);
    RETURN;
END

IF ISNULL(COLUMNPROPERTY(OBJECT_ID(N'dbo.Patients'), N'PatientId', 'IsIdentity'), 0) <> 1
BEGIN
    RAISERROR('Patients.PatientId is not generated automatically. Reset and run setup before loading demo data.', 16, 1);
    RETURN;
END

IF COL_LENGTH(N'dbo.Patients', N'Department') IS NOT NULL
    OR COL_LENGTH(N'dbo.DoctorProfiles', N'Department') IS NOT NULL
    OR COL_LENGTH(N'dbo.PatientVitals', N'Room') IS NOT NULL
    OR OBJECT_ID(N'dbo.BedStatuses', N'U') IS NOT NULL
BEGIN
    RAISERROR('Old department, room, or bed schema detected. Reset and run setup before loading demo data.', 16, 1);
    RETURN;
END

IF EXISTS (SELECT 1 FROM dbo.Patients)
    OR EXISTS (SELECT 1 FROM dbo.DoctorProfiles)
    OR EXISTS (SELECT 1 FROM dbo.Appointments)
    OR EXISTS (SELECT 1 FROM dbo.InventoryItems)
    OR EXISTS (SELECT 1 FROM dbo.InventoryTransactions)
    OR EXISTS (SELECT 1 FROM dbo.ChatConversations)
    OR EXISTS (SELECT 1 FROM dbo.ChatMessages)
    OR EXISTS (SELECT 1 FROM dbo.PatientVitals)
    OR EXISTS (SELECT 1 FROM dbo.SystemNotifications)
BEGIN
    RAISERROR('The database already contains application data. Run a reset script before loading demo data.', 16, 1);
    RETURN;
END

SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @Today DATETIME2 = CAST(CONVERT(DATE, GETDATE()) AS DATETIME2);
    DECLARE @Now DATETIME2 = SYSDATETIME();

    INSERT INTO dbo.DoctorProfiles
        (UserId, Username, DisplayName, IsActive)
    VALUES
        (N'doctor-adams', N'adams', N'Dr. Adams', 1),
        (N'doctor-chen', N'chen', N'Dr. Chen', 1),
        (N'doctor-patel', N'patel', N'Dr. Patel', 1),
        (N'doctor-rivera', N'rivera', N'Dr. Rivera', 1),
        (N'doctor-kim', N'kim', N'Dr. Kim', 1);

    INSERT INTO dbo.Patients
        (PatientUserId, Name, Gender, DateOfBirth, Phone, IsAdmitted, Notes)
    VALUES
        (N'patient-ava', N'Ava Johnson', N'Female', '1988-04-12', N'555-0201', 1, N'Admitted for chest pain observation.'),
        (N'patient-marcus', N'Marcus Lee', N'Male', '1975-09-23', N'555-0202', 1, N'Critical monitoring for respiratory distress.'),
        (N'patient-sofia', N'Sofia Patel', N'Female', '2017-02-08', N'555-0203', 0, N'Outpatient fever follow-up.'),
        (N'patient-daniel', N'Daniel Brooks', N'Male', '1966-11-30', N'555-0204', 1, N'Admitted for diabetes medication adjustment.'),
        (N'patient-elena', N'Elena Garcia', N'Female', '1992-07-19', N'555-0205', 0, N'Imaging consultation scheduled.'),
        (N'patient-olivia', N'Olivia Chen', N'Female', '1981-12-03', N'555-0206', 1, N'Post-op recovery after appendectomy.'),
        (N'patient-noah', N'Noah Williams', N'Male', '1958-05-15', N'555-0207', 0, N'Discharged after pneumonia treatment.'),
        (N'patient-mia', N'Mia Thompson', N'Female', '2004-10-10', N'555-0208', 0, N'Outpatient ankle injury follow-up.'),
        (N'patient-ethan', N'Ethan Davis', N'Male', '1949-03-04', N'555-0209', 1, N'Cardiac monitoring after procedure.'),
        (N'patient-isabella', N'Isabella Martinez', N'Female', '2014-06-29', N'555-0210', 1, N'Admitted overnight for asthma observation.'),
        (N'patient-amelia', N'Amelia Wilson', N'Female', '1971-01-22', N'555-0212', 1, N'Admitted for infection monitoring.'),
        (N'patient-henry', N'Henry King', N'Male', '1952-07-07', N'555-0217', 1, N'Post-op hip replacement recovery.');

    INSERT INTO dbo.Appointments
        (PatientId, DoctorProfileId, VisitReason, AppointmentDateTime, AppointmentStatus, CompletionMessageSent, Notes, CreatedAt)
    SELECT
        p.PatientId,
        d.DoctorProfileId,
        appt.VisitReason,
        appt.AppointmentDateTime,
        appt.AppointmentStatus,
        appt.CompletionMessageSent,
        appt.Notes,
        appt.CreatedAt
    FROM
    (
        VALUES
            (N'Ava Johnson', N'Dr. Adams', N'Chest Pain', DATEADD(HOUR, 9, @Today), N'Scheduled', 0, N'Cardiac observation follow-up.', DATEADD(DAY, -2, @Now)),
            (N'Marcus Lee', N'Dr. Chen', N'Respiratory Distress', DATEADD(MINUTE, 30, DATEADD(HOUR, 10, @Today)), N'Checked In', 0, N'Physician review.', DATEADD(HOUR, -6, @Now)),
            (N'Mia Thompson', N'Dr. Adams', N'Ankle Injury', DATEADD(HOUR, 12, @Today), N'Scheduled', 0, N'Emergency follow-up.', DATEADD(DAY, -1, @Now)),
            (N'Sofia Patel', N'Dr. Patel', N'Pediatric Fever', DATEADD(HOUR, 9, DATEADD(DAY, 1, @Today)), N'Scheduled', 0, N'Parent requested follow-up.', DATEADD(DAY, -2, @Now)),
            (N'Olivia Chen', N'Dr. Rivera', N'Post-op Review', DATEADD(HOUR, 16, DATEADD(DAY, 2, @Today)), N'Scheduled', 0, N'Surgery recovery review.', DATEADD(DAY, -1, @Now)),
            (N'Daniel Brooks', N'Dr. Kim', N'Diabetes Check', DATEADD(HOUR, 14, DATEADD(DAY, -1, @Today)), N'Completed', 1, N'Medication plan updated.', DATEADD(DAY, -2, @Now)),
            (N'Ethan Davis', N'Dr. Chen', N'Cardiac Monitoring', DATEADD(HOUR, 10, DATEADD(DAY, -1, @Today)), N'Completed', 1, N'Cardiac rhythm stable.', DATEADD(DAY, -2, @Now)),
            (N'Isabella Martinez', N'Dr. Patel', N'Asthma', DATEADD(HOUR, 13, DATEADD(DAY, -2, @Today)), N'Completed', 1, N'Inhaler instructions reviewed.', DATEADD(DAY, -3, @Now)),
            (N'Amelia Wilson', N'Dr. Kim', N'Infection Review', DATEADD(HOUR, 15, DATEADD(DAY, -2, @Today)), N'Completed', 1, N'Lab follow-up ordered.', DATEADD(DAY, -3, @Now)),
            (N'Noah Williams', N'Dr. Chen', N'Pneumonia Follow-up', DATEADD(HOUR, 8, DATEADD(DAY, -10, @Today)), N'Completed', 1, N'Discharged with home care instructions.', DATEADD(DAY, -11, @Now)),
            (N'Henry King', N'Dr. Rivera', N'Hip Replacement Recovery', DATEADD(HOUR, 16, DATEADD(DAY, -16, @Today)), N'Completed', 1, N'Post-op mobility evaluation.', DATEADD(DAY, -17, @Now)),
            (N'Elena Garcia', N'Dr. Adams', N'Imaging Consultation', DATEADD(HOUR, 11, DATEADD(DAY, -3, @Today)), N'Cancelled', 0, N'Patient will reschedule.', DATEADD(DAY, -4, @Now))
    ) AS appt(PatientName, DoctorName, VisitReason, AppointmentDateTime, AppointmentStatus, CompletionMessageSent, Notes, CreatedAt)
    INNER JOIN dbo.Patients AS p ON p.Name = appt.PatientName
    INNER JOIN dbo.DoctorProfiles AS d ON d.DisplayName = appt.DoctorName;

    INSERT INTO dbo.InventoryItems
        (ItemName, Category, Quantity, ReorderLevel, StorageLocation, UpdatedAt)
    VALUES
        (N'Insulin Pens', N'Medication', 8, 10, N'Pharmacy Refrigerator', @Now),
        (N'IV Saline Bags', N'General Supply', 18, 20, N'Supply Area A', @Now),
        (N'Sterile Gloves', N'Surgical Supply', 75, 100, N'Supply Area B', @Now),
        (N'Rapid Flu Tests', N'Lab Supply', 35, 25, N'Lab Cabinet 2', @Now),
        (N'Portable Pulse Oximeter', N'Equipment', 6, 5, N'Equipment Closet', @Now),
        (N'Amoxicillin Capsules', N'Medication', 42, 30, N'Pharmacy Shelf 3', @Now),
        (N'Morphine Vials', N'Medication', 12, 15, N'Controlled Medication Locker', @Now),
        (N'Albuterol Inhalers', N'Medication', 9, 12, N'Pharmacy Shelf 1', @Now),
        (N'Suture Kits', N'Surgical Supply', 22, 25, N'Surgical Supply Area', @Now);

    INSERT INTO dbo.InventoryTransactions
        (InventoryItemId, ItemName, Category, QuantityChange, TransactionReason, CreatedAt)
    SELECT item.InventoryItemId, txn.ItemName, txn.Category, txn.QuantityChange, txn.TransactionReason, txn.CreatedAt
    FROM
    (
        VALUES
            (N'Insulin Pens', N'Medication', 70, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'Insulin Pens', N'Medication', -62, N'Dispensed to admitted patients', DATEADD(HOUR, -5, @Now)),
            (N'Albuterol Inhalers', N'Medication', 45, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'Albuterol Inhalers', N'Medication', -36, N'Pediatrics asthma treatment', DATEADD(DAY, -2, @Now)),
            (N'Amoxicillin Capsules', N'Medication', 90, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'Amoxicillin Capsules', N'Medication', -48, N'General pharmacy dispensing', DATEADD(DAY, -3, @Now)),
            (N'Morphine Vials', N'Medication', 35, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'Morphine Vials', N'Medication', -23, N'Surgery recovery use', DATEADD(HOUR, -4, @Now)),
            (N'IV Saline Bags', N'General Supply', 120, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'IV Saline Bags', N'General Supply', -102, N'Urgent treatment area', DATEADD(DAY, -2, @Now)),
            (N'Sterile Gloves', N'Surgical Supply', 500, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'Sterile Gloves', N'Surgical Supply', -425, N'Surgery and emergency carts', DATEADD(HOUR, -8, @Now)),
            (N'Suture Kits', N'Surgical Supply', 45, N'Initial stock', DATEADD(DAY, -30, @Now)),
            (N'Suture Kits', N'Surgical Supply', -23, N'Surgery procedures', DATEADD(DAY, -2, @Now))
    ) AS txn(ItemName, Category, QuantityChange, TransactionReason, CreatedAt)
    INNER JOIN dbo.InventoryItems AS item ON item.ItemName = txn.ItemName;

    INSERT INTO dbo.ChatConversations
        (ConversationName, PatientId, ConversationType, CreatedAt)
    SELECT N'Patient: ' + p.Name, p.PatientId, N'Patient', chat.CreatedAt
    FROM
    (
        VALUES
            (N'Ava Johnson', DATEADD(DAY, -14, @Now)),
            (N'Marcus Lee', DATEADD(DAY, -13, @Now)),
            (N'Sofia Patel', DATEADD(DAY, -12, @Now)),
            (N'Daniel Brooks', DATEADD(DAY, -11, @Now)),
            (N'Olivia Chen', DATEADD(DAY, -10, @Now)),
            (N'Noah Williams', DATEADD(DAY, -9, @Now)),
            (N'Isabella Martinez', DATEADD(DAY, -8, @Now)),
            (N'Amelia Wilson', DATEADD(DAY, -7, @Now)),
            (N'Henry King', DATEADD(DAY, -6, @Now))
    ) AS chat(PatientName, CreatedAt)
    INNER JOIN dbo.Patients AS p ON p.Name = chat.PatientName;

    INSERT INTO dbo.ChatMessages
        (ChatConversationId, SenderName, SenderRole, MessageText, CreatedAt)
    SELECT conversation.ChatConversationId, msg.SenderName, msg.SenderRole, msg.MessageText, msg.CreatedAt
    FROM
    (
        VALUES
            (N'Ava Johnson', N'Nurse Station', N'Nurse', N'Your observation area is ready. Please press the call button if pain changes.', DATEADD(DAY, -13, @Now)),
            (N'Ava Johnson', N'Dr. Adams', N'Doctor', N'Your follow-up is scheduled for today.', DATEADD(HOUR, -3, @Now)),
            (N'Marcus Lee', N'Dr. Chen', N'Doctor', N'Respiratory team will review your oxygen levels this morning.', DATEADD(HOUR, -4, @Now)),
            (N'Sofia Patel', N'Dr. Patel', N'Doctor', N'Pediatric follow-up instructions were sent to the family.', DATEADD(DAY, -11, @Now)),
            (N'Daniel Brooks', N'Hospital System', N'System', N'Thank you for visiting. Please contact hospital staff here if you have follow-up questions.', DATEADD(DAY, -1, @Now)),
            (N'Olivia Chen', N'Nurse Station', N'Nurse', N'Your post-op review is scheduled and recovery notes are being monitored.', DATEADD(HOUR, -8, @Now)),
            (N'Noah Williams', N'Hospital System', N'System', N'Thank you for visiting. Please contact hospital staff here if you have follow-up questions.', DATEADD(DAY, -9, @Now)),
            (N'Isabella Martinez', N'Dr. Patel', N'Doctor', N'Asthma action plan was reviewed with the family.', DATEADD(DAY, -2, @Now)),
            (N'Amelia Wilson', N'Dr. Kim', N'Doctor', N'Lab results are pending and antibiotics are continuing.', DATEADD(HOUR, -11, @Now)),
            (N'Henry King', N'Nurse Station', N'Nurse', N'Physical therapy will visit before the next post-op check.', DATEADD(DAY, -3, @Now))
    ) AS msg(PatientName, SenderName, SenderRole, MessageText, CreatedAt)
    INNER JOIN dbo.Patients AS p ON p.Name = msg.PatientName
    INNER JOIN dbo.ChatConversations AS conversation ON conversation.PatientId = p.PatientId;

    INSERT INTO dbo.PatientVitals
        (PatientId, HeartRate, BloodPressure, OxygenLevel, Temperature, VitalsStatus, Notes, UpdatedAt)
    SELECT p.PatientId, vitals.HeartRate, vitals.BloodPressure, vitals.OxygenLevel, vitals.Temperature, vitals.VitalsStatus, vitals.Notes, vitals.UpdatedAt
    FROM
    (
        VALUES
            (N'Marcus Lee', 136, N'188/102', 88, 102.7, N'Critical', N'Oxygen below target; respiratory team notified.', DATEADD(MINUTE, -25, @Now)),
            (N'Ethan Davis', 132, N'176/96', 89, 99.8, N'Critical', N'Cardiac and oxygen monitoring escalated.', DATEADD(MINUTE, -55, @Now)),
            (N'Ava Johnson', 118, N'148/91', 94, 100.5, N'Warning', N'Chest pain observation with elevated pulse.', DATEADD(HOUR, -2, @Now)),
            (N'Isabella Martinez', 116, N'112/72', 93, 99.9, N'Warning', N'Asthma observation with oxygen below target.', DATEADD(HOUR, -3, @Now)),
            (N'Daniel Brooks', 82, N'124/78', 97, 98.4, N'Normal', N'Glucose control review stable.', DATEADD(HOUR, -6, @Now)),
            (N'Amelia Wilson', 101, N'136/84', 96, 99.6, N'Normal', N'Infection monitoring stable.', DATEADD(HOUR, -8, @Now)),
            (N'Olivia Chen', 96, N'132/82', 96, 99.1, N'Normal', N'Post-op pain controlled.', DATEADD(HOUR, -9, @Now)),
            (N'Henry King', 105, N'138/84', 95, 99.4, N'Normal', N'Mobility improving after procedure.', DATEADD(HOUR, -12, @Now))
    ) AS vitals(PatientName, HeartRate, BloodPressure, OxygenLevel, Temperature, VitalsStatus, Notes, UpdatedAt)
    INNER JOIN dbo.Patients AS p ON p.Name = vitals.PatientName;

    INSERT INTO dbo.SystemNotifications
        (NotificationType, MessageText, CreatedAt)
    VALUES
        (N'System', N'Demo data loaded for analytics and workflow testing.', @Now),
        (N'Dashboard', N'Demo data includes admitted patients, low-stock items, and critical vitals.', DATEADD(MINUTE, -2, @Now)),
        (N'Emergency', N'Critical vitals recorded for Marcus Lee.', DATEADD(MINUTE, -25, @Now)),
        (N'Emergency', N'Critical vitals recorded for Ethan Davis.', DATEADD(MINUTE, -55, @Now)),
        (N'Inventory', N'Insulin Pens, Albuterol Inhalers, Morphine Vials, Sterile Gloves, IV Saline Bags, and Suture Kits are below reorder level.', DATEADD(HOUR, -1, @Now)),
        (N'Appointment', N'Today includes scheduled and checked-in appointments.', DATEADD(HOUR, -3, @Now)),
        (N'Chat', N'Patient chat conversations include sample messages across current and historical visits.', DATEADD(HOUR, -4, @Now)),
        (N'Vitals', N'Warning and critical vitals are available for monitoring.', DATEADD(HOUR, -5, @Now)),
        (N'Inventory', N'Medication usage transactions are available for the analytics medication report.', DATEADD(DAY, -1, @Now)),
        (N'Patient', N'Discharged patient examples are available for filtering.', DATEADD(DAY, -2, @Now));

    COMMIT TRANSACTION;
    PRINT 'Demo data has been loaded into the HospitalManagement SQL database.';
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    THROW;
END CATCH;
