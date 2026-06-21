using System;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    internal static class UserRepository
    {
        public static User FindByUsername(string username)
        {
            IMongoCollection<User> users = AppConnections.GetUsersCollection();
            return users.Find(u => u.Username == username).FirstOrDefault();
        }

        public static void Insert(User user)
        {
            AppConnections.GetUsersCollection().InsertOne(user);
        }

        public static void Save(User user)
        {
            IMongoCollection<User> users = AppConnections.GetUsersCollection();

            if (!String.IsNullOrWhiteSpace(user.Id))
            {
                users.ReplaceOne(u => u.Id == user.Id, user);
                return;
            }

            users.ReplaceOne(u => u.Username == user.Username, user);
        }

        public static bool IsPasswordValid(User user, string password)
        {
            if (!String.IsNullOrEmpty(user.Password) && user.Password == password)
            {
                EnsureStableUserId(user);
                return true;
            }

            return false;
        }

        public static void EnsureStableUserId(User user)
        {
            bool userWasChanged = false;

            if (String.IsNullOrWhiteSpace(user.UserId))
            {
                user.UserId = Guid.NewGuid().ToString();
                userWasChanged = true;
            }

            if (String.IsNullOrWhiteSpace(user.DisplayName))
            {
                user.DisplayName = user.Username;
                userWasChanged = true;
            }

            if (userWasChanged)
            {
                Save(user);
            }
        }
    }
}
