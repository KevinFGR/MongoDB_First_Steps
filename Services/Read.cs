using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services;
public class Read
{
    // accessing the sample_mflix database and returning some regisers
    public async Task readCollection()
    {
        Connection connection = new Connection("db_test", "db_test_collection"); 

        // the expression (_=>true) will return all documents in the colllection
        // If you want something more specifically you also can. Example: (d =>d.Name = "Jose") 
        List<UserModel> documents =  await connection.Collection.Find(_ => true).ToListAsync();

        foreach(var d in documents){
            Console.WriteLine(d.ToJson());
        }
    }
    public async Task read_collection_using_mongoBuilder(){
        // Using Mongo Bilder query

        Connection connection = new Connection("db_test", "db_test_collection");
        
        var query = Builders<UserModel>.Filter.Eq("name", "Kevin Felipe");

        List<UserModel> documents = await connection.Collection.Find(query).ToListAsync();

        foreach(var d in documents){
            Console.WriteLine(d.ToJson());
        }
    }

}
        
