using Gas_Watersupply.Data;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BlszorApp2.Data
{
    public class MD
    {
        private string connection = "mongodb://localhost:27017";
        private IMongoDatabase database;

        public MD()
        {
            var client = new MongoClient(connection);
            database = client.GetDatabase("User");
        }

        public void AddUser(Account account)
        {
            var collection = database.GetCollection<Account>("Useres");
            collection.InsertOne(account);
        }
        public void AddDeveloper(Developer account)
        {
            var collection = database.GetCollection<Developer>("Developer");
            collection.InsertOne(account);
        }
        public void AddCustomer(Customer account)
        {
            var collection = database.GetCollection<Customer>("Customer");
            collection.InsertOne(account);
        }
        public void AddDesigner(Designer account)
        {
            var collection = database.GetCollection<Designer>("Designer");
            collection.InsertOne(account);
        }


        public List<Developer> ListDeveloper()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Developer>("Developer");
            using var cursor = collection.FindAsync(new BsonDocument()).Result;
            return cursor.ToList();
        }
        public List<Customer> ListCustomer()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Customer>("Customer");
            using var cursor = collection.FindAsync(new BsonDocument()).Result;
            return cursor.ToList();
        }
        public List<Designer> ListDesigner()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Designer>("Designer");
            using var cursor = collection.FindAsync(new BsonDocument()).Result;
            return cursor.ToList();
        }

        public  void ChangeDeveloper(Developer developer)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Developer>("Developer");
            collection.ReplaceOne(x => x.Login == developer.Login && x.Password ==developer.Password, developer);
        }

        public void ChangeDesigner(Designer designer)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Designer>("Designer");
            collection.ReplaceOne(x => x.Login == designer.Login && x.Password == designer.Password, designer);
        }

        public void ChangeCustomer(Customer customer)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("User");
            var collection = database.GetCollection<Customer>("Customer");
            collection.ReplaceOne(x => x.Login == customer.Login && x.Password == customer.Password, customer);
        }

        //public Account GetDeveloper(string login,string password)
        //{

        //    var collection = database.GetCollection<Account>("Useres");
        //    var cursor =  collection.Find(X=>X.Login==login && X.Password==password).FirstOrDefault();
        //    return cursor;
        //}


    }
}
