using System.Runtime.CompilerServices;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.Aggregation;

public class Group{
    public async Task group_aggregation(){
        Connection connection = new Connection();

        FilterDefinition<UserModel> filter = Builders<UserModel>.Filter.Lte(d=>d.Age,60);

        // Take just the documents who has the Age <=60 and agroup the by the born date 
        // You can also remove the Match methond and use just the Group method to agroup all the documents without the match filter
        var aggregate = connection.Collection.Aggregate().Match(filter)
            .Group(
                d=>d.BornDate,
                // return just a JSON with the BornDate as key + a Total attributo witch counts how many documents has this BornDate
                group => new{
                    Borndate = group.Key,
                    Total = group.Sum(d=>1)
                }
            );
        var documents = await aggregate.ToListAsync();

        foreach(var d in documents){
            Console.WriteLine(d);
        }
    }

}