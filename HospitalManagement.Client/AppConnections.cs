using System;
using System.Configuration;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    internal static class AppConnections
    {
        public static string GetMongoConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MongoConnection"].ConnectionString;
        }

        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HospitalSqlConnection"].ConnectionString;
        }

        public static string GetSignalRHubUrl()
        {
            string hubUrl = ConfigurationManager.AppSettings["SignalRHubUrl"];

            if (String.IsNullOrWhiteSpace(hubUrl))
            {
                hubUrl = "http://localhost:5068/hospitalHub";
            }

            return hubUrl;
        }

        public static IMongoCollection<User> GetUsersCollection()
        {
            string mongoConnectionString = GetMongoConnectionString();
            MongoClient client = new MongoClient(mongoConnectionString);
            IMongoDatabase database = client.GetDatabase(MongoUrl.Create(mongoConnectionString).DatabaseName);
            return database.GetCollection<User>("Users");
        }
    }
}
