using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HospitalManagement.Client
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
