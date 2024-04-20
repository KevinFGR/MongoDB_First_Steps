using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.Aggregation;

public class Project{
    public async Task projecting(){
        Connection connection = new Connection();

        // you can return another Modeltype using the Projection method
        var project = Builders<UserModel>.Projection.
            Expression(model=> new{
                mId = model.Id,
                mName = model.Name,
                mBornYear = model.BornDate.Year
            });

        var documents = await connection.Collection.Aggregate().Project(project).ToListAsync();

        foreach(var d in documents){
            Console.WriteLine(d.ToJson());
        }
    }
}