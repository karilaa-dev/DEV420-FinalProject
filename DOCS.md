# Hospital Management System User Guide

This guide explains the app roles, visible tabs, and main actions. The app shows different screens based on the logged-in role.

## Role Summary

| Role | Main purpose | Data access | Main restrictions |
| --- | --- | --- | --- |
| Administrative Staff | Manage hospital operations | All patients, all appointments, all patient chats, inventory, reports, vitals, dashboard | Does not use the doctor-only `My Visits` tab or patient-only tabs |
| Nurse | Manage patient care work | All patients, all appointments, all patient chats, vitals, dashboard | No `Inventory` or `Reports` tabs |
| Doctor | Work assigned visits | Assigned patients, assigned appointments, assigned patient chats, vitals for assigned patients | No `Dashboard`, `Inventory`, `Reports`, or unrelated patient records |
| Patient | View personal care | Own care summary, own appointments, own single patient chat | No staff tools and no other patient data |

## Tab Access Matrix

| Area | Administrative Staff | Nurse | Doctor | Patient |
| --- | --- | --- | --- | --- |
| `Login / Register` | Yes | Yes | Yes | Yes |
| `Dashboard` | Yes | Yes | No | No |
| `My Visits` | No | No | Yes | No |
| `My Care` | No | No | No | Yes |
| `Patients` | Yes | Yes | Assigned only | No |
| `Appointments` | Yes | Yes | Assigned only | Own only |
| `Inventory` | Yes | No | No | No |
| `Reports` | Yes | No | No | No |
| `Messages` | Yes | Yes | Assigned only | No |
| `My Messages` | No | No | No | Yes |
| `Vitals` | Yes | Yes | Assigned only | No edit access |
| `Notifications` | Yes | Yes | Related updates | Own updates |
| `Logout` | Yes | Yes | Yes | Yes |

## Login and Register

| Field | Details |
| --- | --- |
| Who can view | Anyone before logging in |
| What it shows | Login form, register form, role picker |
| Available actions | Log in, register a new account |
| Who can use actions | Anyone can register as Doctor, Nurse, Administrative Staff, or Patient for this school project |
| Result | After login, only role-allowed tabs appear |

## Dashboard

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff, Nurse |
| What it shows | Active patients, appointments today, low-stock count, emergency alerts, current alerts |
| Available actions | Review hospital status and watch live updates |
| Who can use actions | Administrative Staff can also see low-stock inventory alerts; Nurse sees patient, appointment, and vitals alerts |
| Demo value | Good first screen for showing real-time hospital status |

## My Visits

| Field | Details |
| --- | --- |
| Who can view | Doctor |
| What it shows | Today's assigned visits, selected visit details, last completed visit |
| Available actions | Select a visit, review details, click `Text Patient` |
| Who can use actions | Doctor can only open chats for assigned patients |
| Demo value | Shows the doctor-focused workflow before updating an appointment |

## My Care

| Field | Details |
| --- | --- |
| Who can view | Patient |
| What it shows | Next appointment, latest vitals, care status, notes |
| Available actions | Review appointment and vitals information |
| Who can use actions | Patient can only view their own information here |
| Demo value | Shows what the patient sees after staff update appointments, admission status, messages, and vitals |

## Patients

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff, Nurse, Doctor |
| What it shows | Patient list, patient details form, search box, patient filters |
| Available actions | Search, filter, double-click a row, add patient, save changes, delete patient, clear form |
| Who can use actions | Administrative Staff and Nurse can add/update/delete; Doctor can view assigned patients only |
| Important labels | `Currently Admitted`, `Add Patient`, `Save Changes`, `Delete Patient`, `Clear Form` |

## Appointments

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff, Nurse, Doctor, Patient |
| What it shows | Appointment list and appointment form |
| Available actions | Add appointment, double-click appointment, update status/notes, refresh, clear form |
| Who can use actions | Administrative Staff and Nurse can create/manage appointments; Patient can create own appointment; Doctor can update status and notes for assigned appointments |
| Important statuses | `Scheduled`, `Checked In`, `Completed`, `Cancelled`, `Rescheduled` |
| Important behavior | Setting status to `Completed` sends an automatic follow-up message to the patient chat |

## Inventory

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff |
| What it shows | Inventory grid, low-stock list, inventory item form |
| Available actions | Add item, update quantity, update reorder level, update location, remove item, refresh |
| Who can use actions | Administrative Staff only |
| Demo value | Shows stock tracking, low-stock alerts, and inventory notifications |

## Reports

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff |
| What it shows | Date filters, report type picker, report summary, report output grid |
| Available actions | Choose report type and click `Run Report` |
| Who can use actions | Administrative Staff only |
| Report types | `Patient Visits`, `Common Ailments`, `Medication Usage` |

## Messages

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff, Nurse, Doctor |
| What it shows | Patient conversation list, selected conversation history, message input |
| Available actions | Start patient chat, select conversation, send message |
| Who can use actions | Administrative Staff and Nurse can use all patient chats; Doctor can use assigned patient chats |
| Important behavior | Staff chats are patient-specific conversations named like `Patient: <patient name>` |

## My Messages

| Field | Details |
| --- | --- |
| Who can view | Patient |
| What it shows | One patient chat for the logged-in patient |
| Available actions | Read messages from staff and send a reply |
| Who can use actions | Patient only |
| Important behavior | Patients cannot create multiple chats; their chat is created automatically |

## Vitals

| Field | Details |
| --- | --- |
| Who can view | Administrative Staff, Nurse, Doctor |
| What it shows | Vitals grid, vitals alert list, vitals entry form |
| Available actions | Add vitals, double-click vitals row, update vitals, refresh, clear form |
| Who can use actions | Administrative Staff and Nurse can update accessible patients; Doctor can update assigned patients |
| Status results | `Normal`, `Warning`, or `Critical` |
| Important behavior | `Warning` and `Critical` vitals create alerts and notifications |

## Notifications

| Field | Details |
| --- | --- |
| Who can view | All logged-in users |
| What it shows | Recent updates allowed for the current role |
| Available actions | Click `Notifications` in the header and review updates |
| Who can use actions | All logged-in users |
| Role filtering | Administrative Staff and Nurse see broad updates; Doctor sees assigned-patient updates; Patient sees own-care updates |

## Logout

| Field | Details |
| --- | --- |
| Who can view | All logged-in users |
| What it shows | `Logout` button in the header |
| Available actions | Click `Logout` |
| Who can use actions | All logged-in users |
| Result | Main window closes and returns to the login screen |
