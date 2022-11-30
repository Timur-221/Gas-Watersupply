using BlszorApp2.Data;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Components.Forms;

namespace Gas_Watersupply.Data
{
    public class Developer 
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string Email { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string RepeatPassword { get; set; }
        public int OGRN { get; set; }

        public int INN { get; set; }

        public int CPP { get; set; }

        public string Adress { get; set; }

        public string Supervisor { get; set; }

        [BsonIgnore]
        public List<IBrowserFile> BrowserFiles { get; set; } = new List<IBrowserFile>();

        [BsonIgnore]
        public List<MainFile> DeveloperMainFile { get; set; } = new List<MainFile>();
    }
}
