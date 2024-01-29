using MongoDB.Driver;

namespace MongoExamples
{
    public class CRUD
    {
        public static void CreateUser(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("322Group");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static void GetUser(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("322Group");
            var collection = database.GetCollection<User>("Users");
            var user = collection.Find(x => x.Name == name).FirstOrDefault();

            if(user != null)
                Console.WriteLine($"{user.Name} {user.Age}");
            else
                Console.WriteLine("Not found");
        }
    }
}
