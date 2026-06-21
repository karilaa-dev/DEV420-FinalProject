using System;
using System.IO;
using System.Text.Json;
using MongoDB.Driver;

namespace HospitalManagement.Client
{
    internal static class AppConnections
    {
        private static readonly Lazy<AppSettings> Settings = new Lazy<AppSettings>(LoadSettings);

        public static string GetMongoConnectionString()
        {
            string connectionString = Settings.Value.ConnectionStrings?.MongoConnection;

            if (String.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = Settings.Value.MongoAccount?.ConnectionString;
            }

            return RequireSetting(connectionString, "ConnectionStrings:MongoConnection");
        }

        public static string GetSqlConnectionString()
        {
            return RequireSetting(
                Settings.Value.ConnectionStrings?.HospitalSqlConnection,
                "ConnectionStrings:HospitalSqlConnection");
        }

        public static string GetSignalRHubUrl()
        {
            string hubUrl = Settings.Value.SignalRHubUrl;

            if (String.IsNullOrWhiteSpace(hubUrl))
            {
                hubUrl = "http://localhost:5068/hospitalHub";
            }

            return hubUrl;
        }

        public static IMongoCollection<User> GetUsersCollection()
        {
            string mongoConnectionString = GetMongoConnectionString();
            string mongoDatabaseName = Settings.Value.MongoAccount?.DatabaseName;

            if (String.IsNullOrWhiteSpace(mongoDatabaseName))
            {
                mongoDatabaseName = MongoUrl.Create(mongoConnectionString).DatabaseName;
            }

            mongoDatabaseName = RequireSetting(
                mongoDatabaseName,
                "MongoAccount:DatabaseName");

            MongoClient client = new MongoClient(mongoConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDatabaseName);
            return database.GetCollection<User>("Users");
        }

        private static AppSettings LoadSettings()
        {
            string settingsPath = FindAppSettingsPath();
            string json = File.ReadAllText(settingsPath);
            AppSettings settings = JsonSerializer.Deserialize<AppSettings>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new AppSettings();

            return settings;
        }

        private static string FindAppSettingsPath()
        {
            string[] startPaths =
            {
                AppContext.BaseDirectory,
                Directory.GetCurrentDirectory()
            };

            foreach (string startPath in startPaths)
            {
                DirectoryInfo directory = new DirectoryInfo(startPath);

                while (directory != null)
                {
                    string candidate = Path.Combine(directory.FullName, "appsettings.json");

                    if (File.Exists(candidate))
                    {
                        return candidate;
                    }

                    directory = directory.Parent;
                }
            }

            throw new FileNotFoundException("Could not find appsettings.json in the application output or solution folder.");
        }

        private static string RequireSetting(string value, string key)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException(key + " is required in appsettings.json.");
            }

            return value;
        }

        private sealed class AppSettings
        {
            public ConnectionStringSettings ConnectionStrings { get; set; }

            public string SignalRHubUrl { get; set; }

            public MongoAccountSettings MongoAccount { get; set; }
        }

        private sealed class ConnectionStringSettings
        {
            public string HospitalSqlConnection { get; set; }

            public string MongoConnection { get; set; }
        }

        private sealed class MongoAccountSettings
        {
            public string ConnectionString { get; set; }

            public string DatabaseName { get; set; }
        }
    }
}
