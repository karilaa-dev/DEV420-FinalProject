using System;
using System.Linq;

namespace HospitalManagement.Client
{
    internal static class SqlUserProfileSync
    {
        public static void SyncUserProfile(User user)
        {
            if (user == null)
            {
                return;
            }

            UserRepository.EnsureStableUserId(user);

            if (user.Role == HospitalRoles.Doctor)
            {
                EnsureDoctorProfile(user);
            }
            else if (user.Role == HospitalRoles.Patient)
            {
                EnsurePatientProfile(user);
            }
        }

        public static void EnsureDoctorProfile(User user)
        {
            using (HospitalDbContext db = new HospitalDbContext())
            {
                DoctorProfile profile = db.DoctorProfiles.FirstOrDefault(p => p.UserId == user.UserId);

                if (profile == null)
                {
                    profile = db.DoctorProfiles.FirstOrDefault(p => p.Username == user.Username);
                }

                if (profile == null)
                {
                    profile = new DoctorProfile
                    {
                        UserId = user.UserId,
                        Username = user.Username,
                        DisplayName = GetDoctorDisplayName(user),
                        IsActive = true,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };

                    db.DoctorProfiles.Add(profile);
                }
                else
                {
                    profile.UserId = user.UserId;
                    profile.Username = user.Username;
                    profile.DisplayName = GetDoctorDisplayName(user);
                    profile.IsActive = true;
                    profile.UpdatedAt = DateTime.Now;
                }

                db.SaveChanges();
            }
        }

        public static int EnsurePatientProfile(User user)
        {
            using (HospitalDbContext db = new HospitalDbContext())
            {
                Patient patient = db.Patients.FirstOrDefault(p => p.PatientUserId == user.UserId);

                if (patient == null)
                {
                    string displayName = GetUserDisplayName(user);

                    patient = db.Patients
                        .OrderBy(p => p.PatientId)
                        .FirstOrDefault(p => p.Name == displayName || p.Name == user.Username);
                }

                if (patient == null)
                {
                    patient = new Patient
                    {
                        PatientUserId = user.UserId,
                        Name = GetUserDisplayName(user),
                        IsAdmitted = false,
                        Notes = "Created from patient registration."
                    };

                    db.Patients.Add(patient);
                }
                else
                {
                    patient.PatientUserId = user.UserId;
                }

                db.SaveChanges();
                return patient.PatientId;
            }
        }

        private static string GetUserDisplayName(User user)
        {
            if (user != null && !String.IsNullOrWhiteSpace(user.DisplayName))
            {
                return user.DisplayName.Trim();
            }

            if (user != null && !String.IsNullOrWhiteSpace(user.Username))
            {
                return user.Username.Trim();
            }

            return "Unknown User";
        }

        private static string GetDoctorDisplayName(User user)
        {
            string displayName = GetUserDisplayName(user);

            if (displayName.StartsWith("Dr. ", StringComparison.OrdinalIgnoreCase))
            {
                return displayName;
            }

            if (displayName.StartsWith("Doctor ", StringComparison.OrdinalIgnoreCase))
            {
                return displayName;
            }

            return "Dr. " + displayName;
        }
    }
}
