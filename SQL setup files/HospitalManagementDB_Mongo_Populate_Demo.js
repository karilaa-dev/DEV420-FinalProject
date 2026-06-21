// Hospital Management System MongoDB demo account data
// Run from Setup-HospitalDatabases.cmd through mongosh.

const targetDatabaseName = process.env.HOSPITAL_MONGO_DATABASE || "HospitalManagementDB";
const hospitalDb = db.getSiblingDB(targetDatabaseName);
const users = hospitalDb.getCollection("Users");

const demoUsers = [
    {
        UserId: "admin-morgan",
        Username: "admin",
        DisplayName: "Morgan Admin",
        Password: "123",
        Role: "Administrative Staff"
    },
    {
        UserId: "admin-casey",
        Username: "casey.admin",
        DisplayName: "Casey Reynolds",
        Password: "123",
        Role: "Administrative Staff"
    },
    {
        UserId: "nurse-taylor",
        Username: "taylor",
        DisplayName: "Taylor Nurse",
        Password: "123",
        Role: "Nurse"
    },
    {
        UserId: "nurse-brown",
        Username: "brown",
        DisplayName: "Jordan Brown",
        Password: "123",
        Role: "Nurse"
    },
    {
        UserId: "nurse-lee",
        Username: "lee.nurse",
        DisplayName: "Riley Lee",
        Password: "123",
        Role: "Nurse"
    },
    {
        UserId: "doctor-adams",
        Username: "adams",
        DisplayName: "Dr. Adams",
        Password: "123",
        Role: "Doctor"
    },
    {
        UserId: "doctor-chen",
        Username: "chen",
        DisplayName: "Dr. Chen",
        Password: "123",
        Role: "Doctor"
    },
    {
        UserId: "doctor-patel",
        Username: "patel",
        DisplayName: "Dr. Patel",
        Password: "123",
        Role: "Doctor"
    },
    {
        UserId: "doctor-rivera",
        Username: "rivera",
        DisplayName: "Dr. Rivera",
        Password: "123",
        Role: "Doctor"
    },
    {
        UserId: "doctor-kim",
        Username: "kim",
        DisplayName: "Dr. Kim",
        Password: "123",
        Role: "Doctor"
    },
    {
        UserId: "patient-ava",
        Username: "ava",
        DisplayName: "Ava Johnson",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-marcus",
        Username: "marcus",
        DisplayName: "Marcus Lee",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-sofia",
        Username: "sofia",
        DisplayName: "Sofia Patel",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-daniel",
        Username: "daniel",
        DisplayName: "Daniel Brooks",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-elena",
        Username: "elena",
        DisplayName: "Elena Garcia",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-olivia",
        Username: "olivia",
        DisplayName: "Olivia Chen",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-noah",
        Username: "noah",
        DisplayName: "Noah Williams",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-mia",
        Username: "mia",
        DisplayName: "Mia Thompson",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-ethan",
        Username: "ethan",
        DisplayName: "Ethan Davis",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-isabella",
        Username: "isabella",
        DisplayName: "Isabella Martinez",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-amelia",
        Username: "amelia",
        DisplayName: "Amelia Wilson",
        Password: "123",
        Role: "Patient"
    },
    {
        UserId: "patient-henry",
        Username: "henry",
        DisplayName: "Henry King",
        Password: "123",
        Role: "Patient"
    }
];

users.createIndex({ UserId: 1 }, { unique: true });
users.createIndex({ Username: 1 }, { unique: true });

for (const user of demoUsers) {
    users.replaceOne(
        { UserId: user.UserId },
        user,
        { upsert: true }
    );
}

print(`Seeded ${demoUsers.length} MongoDB demo users into ${targetDatabaseName}.Users.`);
