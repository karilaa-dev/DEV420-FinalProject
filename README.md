# Hospital Management System

This solution is a DEV420 final project for a Hospital Management System with real-time capabilities.

## .NET Version

The projects currently target .NET 8:

- `HospitalManagement.Server`: `net8.0`
- `HospitalManagement.Client`: `net8.0-windows`

Install the .NET 8 SDK to build and run the solution.

## Projects

- `HospitalManagement.Server` - ASP.NET Core web project. Its goal is to host the backend side of the hospital system, including the API, SignalR real-time updates, and future database/service logic.
- `HospitalManagement.Client` - Windows Forms desktop project. Its goal is to provide the user interface for hospital staff to manage patients, appointments, inventory, analytics, communication, dashboard status, and patient monitoring.

## Project Goal

The goal of the system is to support hospital operations by managing patient records, appointments, medical inventory, reports, staff/patient communication, and real-time status updates through a server and desktop client.

## Setup

1. Start Command Prompt from the solution folder and run `Setup-HospitalDatabases.cmd`, or double-click the script in File Explorer.
2. Use option `5` if the SQL Server or MongoDB connection settings need to be changed.
3. Use option `4` for a full reset, schema setup, and demo data load.
4. Check `HospitalManagement.Client/App.config` on the Windows VM. `HospitalSqlConnection` should point to `HospitalManagementDB_SQL`, `MongoConnection` should point to `HospitalManagementDB`, and `SignalRHubUrl` should point to the server hub, usually `http://localhost:5068/hospitalHub`.
5. Check `HospitalManagement.Server/appsettings.json` so `MongoAccount` points to the same MongoDB database used by the client.
6. Start `HospitalManagement.Server`.
7. Start one or more `HospitalManagement.Client` instances and log in with a MongoDB user.

The database launcher uses these scripts:

- `SQL setup files/HospitalManagementDB_SQL_Setup.sql` creates the SQL schema.
- `SQL setup files/HospitalManagementDB_SQL_Populate_Demo.sql` loads SQL hospital demo records.
- `SQL setup files/HospitalManagementDB_Mongo_Populate_Demo.js` loads MongoDB demo users.

## User Setup

MongoDB remains the login source required by the final project. SQL Server stores hospital records and links them to Mongo users through `PatientUserId` and `DoctorProfiles.UserId`.

1. Register allows choosing a username, display name, password, and role: Doctor, Nurse, Administrative Staff, or Patient.
2. Passwords are stored plainly in MongoDB for this school project.
3. The dashboard `Create User` button is still available to Administrative Staff as a convenience, but it opens the same registration form.
4. MongoDB is the source for account type and display name. SQL stores hospital records linked through Mongo `UserId`.
5. Doctor users are automatically synchronized into SQL `DoctorProfiles`, and the appointment doctor picker only shows active doctor profiles.
6. Demo MongoDB accounts all use password `123`. Examples include `admin`, `taylor`, `adams`, `chen`, `ava`, and `marcus`.
7. Demo doctor and patient SQL records are already linked to matching Mongo `UserId` values.

## Implemented Features

- User registration/login with MongoDB-backed roles, display names, and simple plain-text passwords for school-project use.
- Role-aware SQL Server patient access with generated patient IDs and optional Mongo patient links.
- Appointment scheduling with SQL foreign keys to patients and doctor-user profiles.
- Doctor-side appointment flow for assigned patients, including status/notes updates and vitals entry.
- Administrative-only medical inventory management with low-stock alerts and stock transaction history.
- Administrative-only analytics reports for patient visits, appointment statuses, doctor workload, common appointment reasons, and medication usage.
- Real-time staff-patient communication through patient-specific chat conversations linked by `PatientId`.
- Automated patient follow-up chat message when an appointment is marked completed.
- Patient vitals monitoring with warning/critical status calculation and role-scoped visibility.
- Dashboard counts, critical alerts, notifications, and real-time update feed with client-side role filtering plus server-side SignalR account-type checks.

## Role Permissions

- `Administrative Staff`: full access, user creation, inventory, analytics, all patients, all appointments, all patient chats, and monitoring.
- `Nurse`: patient management, appointments, patient chats, monitoring, and dashboard. No inventory or analytics.
- `Doctor`: assigned patients, assigned appointments, assigned patient chats, monitoring, and dashboard. No inventory, analytics, or unrelated patient records.
- `Patient`: own patient profile, own appointments, own chat, and dashboard. No inventory, analytics, monitoring, or other patient data.

## Build

Run this from the solution folder on the Windows VM:

```bash
dotnet build DEV420-FinalProject.sln
```
