using MongoDB.Bson;

namespace MongoExamples
{
    public class User
    {
        public User(string name, string password, int age)
        {
            Name = name;
            Password = password;
            Age = age;
        }

        public ObjectId _id;
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
