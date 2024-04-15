using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB_First_Steps;
public class Read
{
    // accessing the sample_mfliz database and returning some regisers
    public void read()
    {
        Connection connection = new Connection(); 
        IMongoDatabase database = connection.DB_connect("sample_mflix");
        
        IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("movies");
        
        var query = Builders<BsonDocument>.Filter.Eq("type", "movie");

        var document = collection.Find(query).Limit(10).ToList();


        foreach (var d in document){
        Console.WriteLine(d);

        }

    }

}
