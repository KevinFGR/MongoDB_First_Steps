using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services;
public class Read
{
    // accessing the sample_mflix database and returning some regisers
        public void read_collection()
    {
        Connection connection = new Connection("db_test", "db_test_collection"); 
        
        var query = Builders<UserModel>.Filter.Eq("name", "Kevin Felipe");

        UserModel document = connection.Collection.Find(query).First();

        Console.WriteLine(document);
    }

}
