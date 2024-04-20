using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.Aggregation;

public class Match
{
    public void match_aggregation(){
        Connection connection = new Connection(); 

        FilterDefinition<UserModel> filter = Builders<UserModel>.Filter.Lte(d =>d.Age, 60);

        // Return just the documents that matches with the filter
        IAggregateFluent<UserModel> aggregation = connection.Collection.Aggregate().Match(filter);

        foreach(var d in aggregation.ToList()){
            Console.WriteLine(d.ToJson());
        }
    }
    // A function tha returns the same value but without using match aggregation
    public async Task without_match(){
        Connection connection = new Connection();

        FilterDefinition<UserModel> filter = Builders<UserModel>.Filter.Lte(d=>d.Age, 60);

        List<UserModel> documents = await connection.Collection.Find(filter).ToListAsync();

        foreach(var d in documents){
            Console.WriteLine(d.ToJson());
        }
    }
}
