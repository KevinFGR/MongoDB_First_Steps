using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.Aggregation;

public class Sort{
    public async Task DescendSort(){
        Connection connection = new Connection();

        SortDefinition<UserModel> sort = Builders<UserModel>.Sort.Descending("Age");

        // Instead of declaring the sort var you can call the SortByDescending(lambda) after the Aggregate method
        List<UserModel> documents = await connection.Collection.Aggregate().Sort(sort).ToListAsync();

        foreach(var d in documents){
            Console.WriteLine(d.ToJson());
        }
    }
}