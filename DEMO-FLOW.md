# Hospital Management System Demo Flow

This is the recommended order for the final project demo. It follows one patient through the main hospital workflow, then finishes with the Administrative Staff features.

## Step-by-Step Demo

1. Start with an Administrative Staff login.
   - Open the client and log in as `Administrative Staff`.
   - Open the `Patients` tab.
   - Create a new patient.
   - Fill in the patient details.
   - Click `Add Patient`.
   - Show that the patient appears in the patient grid.
   - Mention that the app also creates a patient chat for this patient.

2. Log out of Administrative Staff.
   - Click `Logout`.
   - Return to the login screen.

3. Log in as Nurse.
   - Log in with a `Nurse` account.
   - Open the `Appointments` tab.
   - Create an appointment for the patient you just added.
   - Select the patient.
   - Pick a doctor from the doctor dropdown.
   - Keep the appointment status as `Scheduled`.
   - Add the visit reason, date, and time.
   - Click `Add Appointment`.
   - Show that the appointment appears in the appointment grid.

4. Show the nurse notification update.
   - Click `Notifications` in the top header.
   - Show the appointment notification.
   - Explain that changes can create real-time updates for the right users.

5. Log out of Nurse.
   - Click `Logout`.
   - Return to the login screen.

6. Log in as the selected Doctor.
   - Log in as the doctor you selected for the appointment.
   - Open the `My Visits` tab.
   - Show that the doctor sees the assigned visit.
   - Select the visit if it is not already selected.
   - Point out that the doctor only sees assigned patient information.

7. Check in the patient.
   - Open the `Appointments` tab.
   - Double-click the appointment for the demo patient.
   - Change the appointment status to `Checked In`.
   - Click `Save Changes`.
   - Show that the appointment status changed.

8. Add vitals for the patient.
   - Open the `Vitals` tab.
   - Select the demo patient.
   - Enter heart rate, blood pressure, oxygen level, temperature, and notes.
   - Click `Add Vitals`.
   - Show the saved vitals record.
   - Point out the calculated status: `Normal`, `Warning`, or `Critical`.

9. Check out the patient.
   - Return to the `Appointments` tab.
   - Double-click the same appointment.
   - Change the appointment status to `Completed`.
   - Click `Save Changes`.
   - Explain that the app sends an automatic follow-up message from `Hospital System`.

10. Send a doctor message to the patient.
    - Open the patient chat from `My Visits` using `Text Patient`, or open it from the `Messages` tab.
    - Type a short message to the patient.
    - Click `Send Message`.
    - Show the message in the chat history.

11. Log out of Doctor.
    - Click `Logout`.
    - Return to the login screen.

12. Log in as Nurse again.
    - Log in with the `Nurse` account.
    - Open the `Patients` tab.
    - Find the demo patient.
    - Double-click the patient row.
    - Check `Currently Admitted`.
    - Click `Save Changes`.
    - Show that the patient status changes to `Admitted`.

13. Send a nurse message to the patient.
    - Open the `Messages` tab.
    - Select the demo patient conversation.
    - Type a second message to the patient.
    - Click `Send Message`.
    - Show the nurse message in the chat history.

14. Show nurse dashboard and notifications.
    - Open the `Dashboard` tab.
    - Show updated counts, bed status, and alerts.
    - Click `Notifications`.
    - Show the recent workflow updates.

15. Log out of Nurse.
    - Click `Logout`.
    - Return to the login screen.

16. Log in as Patient.
    - Log in with the patient account linked to the demo patient.
    - Open `My Care`.
    - Show the next appointment and latest vitals.
    - Explain that the patient only sees their own information.

17. Show the patient's appointments.
    - Open the `Appointments` tab.
    - Show that the patient sees their own appointment only.
    - Point out that the patient does not see staff-wide appointment data.

18. Show the patient's messages.
    - Open the `My Messages` tab.
    - Show the automatic follow-up message from `Hospital System`.
    - Show the doctor message.
    - Show the nurse message.
    - Send a patient reply.
    - Explain that patients have one simple chat with hospital staff.

19. Log out of Patient.
    - Click `Logout`.
    - Return to the login screen.

20. Log in as Administrative Staff for the final overview.
    - Log in with an `Administrative Staff` account.
    - Open the `Dashboard` tab.
    - Show hospital counts, bed availability, current alerts, and broad status visibility.

21. Show inventory features.
    - Open the `Inventory` tab.
    - Show the inventory grid.
    - Show the low-stock list.
    - Point out the add, update, remove, and refresh controls.
    - Explain that inventory is Administrative Staff only.

22. Show report features.
    - Open the `Reports` tab.
    - Pick a report type.
    - Click `Run Report`.
    - Show the report output grid.
    - Mention the available report types: `Patient Visits`, `Common Ailments`, `Medication Usage`, and `Department Load`.

23. Show broad message access.
    - Open the `Messages` tab.
    - Select the demo patient conversation.
    - Show that Administrative Staff can view patient conversations broadly.

24. Show final notifications.
    - Click `Notifications`.
    - Show the recent updates from the demo.
    - End by explaining that the app uses role permissions, scoped patient data, and real-time updates across the hospital workflow.

## Key Points to Say

- Each login shows a different set of tabs based on role permissions.
- Doctor and Patient views are scoped so they do not see unrelated patient data.
- Appointment, inventory, vitals, patient, and message changes can create notifications.
- The patient sees a simple care summary, their own appointments, latest vitals, and one chat with staff.
- Administrative Staff can show the broad operational tools: dashboard, inventory, reports, messages, and notifications.
