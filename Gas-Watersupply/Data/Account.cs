using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BlszorApp2.Data
{
    public class Account
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Job { get; set; }

        public string RepeatPassword { get; set; }

        [BsonIgnoreIfNull]
        public int OGRN { get; set; }
        [BsonIgnoreIfNull]
        public int INN { get; set; }
        [BsonIgnoreIfNull]
        public int CPP { get; set; }
        [BsonIgnoreIfNull]
        public string Adress { get; set; }
        [BsonIgnoreIfNull]
        public string Supervisor { get; set; }

        public bool Valid { get; set; } 
    }
}
