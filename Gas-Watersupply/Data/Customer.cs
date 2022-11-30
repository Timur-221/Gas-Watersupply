using BlszorApp2.Data;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Gas_Watersupply.Data
{
    public class Customer
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string RepeatPassword { get; set; }

    }
}
