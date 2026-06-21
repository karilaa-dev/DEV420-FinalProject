using Microsoft.AspNetCore.SignalR;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddSingleton<MongoAccountRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hospital Management SignalR server is running.");
app.MapHub<HospitalHub>("/hospitalHub");

app.Run();

public class HospitalHub : Hub
{
    private readonly MongoAccountRepository accounts;

    public HospitalHub(MongoAccountRepository accounts)
    {
        this.accounts = accounts;
    }

    public async Task SendAppointmentChanged(string message)
    {
        await RequireRoleAsync(
            HospitalRoles.AdministrativeStaff,
            HospitalRoles.Nurse,
            HospitalRoles.Doctor,
            HospitalRoles.Patient);

        await Clients.All.SendAsync("AppointmentChanged", message);
    }

    public async Task SendInventoryChanged(string message)
    {
        await RequireRoleAsync(HospitalRoles.AdministrativeStaff);
        await Clients.All.SendAsync("InventoryChanged", message);
    }

    public async Task SendPatientChanged(string message)
    {
        await RequireRoleAsync(
            HospitalRoles.AdministrativeStaff,
            HospitalRoles.Nurse,
            HospitalRoles.Patient);

        await Clients.All.SendAsync("PatientChanged", message);
    }

    public async Task SendChatMessage(string conversationName, string senderName, string message)
    {
        await RequireRoleAsync(
            HospitalRoles.AdministrativeStaff,
            HospitalRoles.Nurse,
            HospitalRoles.Doctor,
            HospitalRoles.Patient);

        await Clients.All.SendAsync("ChatMessageReceived", conversationName, senderName, message);
    }

    public async Task SendVitalsChanged(string message)
    {
        await RequireRoleAsync(
            HospitalRoles.AdministrativeStaff,
            HospitalRoles.Nurse,
            HospitalRoles.Doctor);

        await Clients.All.SendAsync("VitalsChanged", message);
    }

    public async Task SendDashboardChanged(string message)
    {
        await RequireRoleAsync(
            HospitalRoles.AdministrativeStaff,
            HospitalRoles.Nurse,
            HospitalRoles.Doctor);

        await Clients.All.SendAsync("DashboardChanged", message);
    }

    public async Task SendNotification(string message)
    {
        await RequireRoleAsync(
            HospitalRoles.AdministrativeStaff,
            HospitalRoles.Nurse,
            HospitalRoles.Doctor);

        await Clients.All.SendAsync("NotificationReceived", message);
    }

    private async Task<UserAccount> RequireRoleAsync(params string[] allowedRoles)
    {
        string? userId = Context.GetHttpContext()?.Request.Query["userId"].ToString();

        if (String.IsNullOrWhiteSpace(userId))
        {
            throw new HubException("A MongoDB user id is required for real-time updates.");
        }

        UserAccount? user = await accounts.FindByUserIdAsync(userId);

        if (user == null)
        {
            throw new HubException("The current user was not found in MongoDB.");
        }

        bool roleIsAllowed = allowedRoles.Any(role =>
            String.Equals(role, user.Role, StringComparison.OrdinalIgnoreCase));

        if (!roleIsAllowed)
        {
            throw new HubException("This account type is not allowed to send this real-time update.");
        }

        return user;
    }
}

public sealed class MongoAccountRepository
{
    private readonly IMongoCollection<UserAccount> users;

    public MongoAccountRepository(IConfiguration configuration)
    {
        MongoAccountOptions options = configuration
            .GetSection("MongoAccount")
            .Get<MongoAccountOptions>() ?? new MongoAccountOptions();

        if (String.IsNullOrWhiteSpace(options.ConnectionString))
        {
            throw new InvalidOperationException("MongoAccount:ConnectionString is required.");
        }

        MongoUrl mongoUrl = MongoUrl.Create(options.ConnectionString);
        string databaseName = !String.IsNullOrWhiteSpace(options.DatabaseName)
            ? options.DatabaseName
            : mongoUrl.DatabaseName;

        if (String.IsNullOrWhiteSpace(databaseName))
        {
            throw new InvalidOperationException("MongoAccount:DatabaseName is required when the connection string does not include a database.");
        }

        string usersCollection = String.IsNullOrWhiteSpace(options.UsersCollection)
            ? "Users"
            : options.UsersCollection;

        MongoClient client = new MongoClient(options.ConnectionString);
        IMongoDatabase database = client.GetDatabase(databaseName);
        users = database.GetCollection<UserAccount>(usersCollection);
    }

    public async Task<UserAccount?> FindByUserIdAsync(string userId)
    {
        return await users
            .Find(user => user.UserId == userId)
            .FirstOrDefaultAsync();
    }
}

public sealed class MongoAccountOptions
{
    public string ConnectionString { get; set; } = "";

    public string DatabaseName { get; set; } = "";

    public string UsersCollection { get; set; } = "Users";
}

public sealed class UserAccount
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string UserId { get; set; } = "";

    public string Username { get; set; } = "";

    public string DisplayName { get; set; } = "";

    public string Password { get; set; } = "";

    public string Role { get; set; } = "";
}

public static class HospitalRoles
{
    public const string Doctor = "Doctor";
    public const string Nurse = "Nurse";
    public const string AdministrativeStaff = "Administrative Staff";
    public const string Patient = "Patient";
}
