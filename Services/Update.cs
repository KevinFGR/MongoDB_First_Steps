using System.ComponentModel;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services;

public class Update
{
    public async Task updateDocument(){
        Connection connection = new Connection("db_test", "db_test_collection");
        
        var filter = Builders<UserModel>.Filter.Eq(d => d.Age, 68);

        var document = Builders<UserModel>.Update.Set(d=>d.Password, "An_Old_Guy");

        var update = await connection.Collection.UpdateOneAsync(filter, document);

        Console.WriteLine($" Matched count: {update.MatchedCount},\n Modified count: {update.ModifiedCount} \n Aknowledged: {update.IsAcknowledged}");
    }

    public async Task updateManyDocuments(){
        Connection connection = new Connection("db_test", "db_test_collection");

        var documents = Builders<UserModel>.Filter.Lt(d=>d.Age, 60);

        // Incrementing 20 years in the Age key
        var changes = Builders<UserModel>.Update.Inc(d=>d.Age, 20);

        var update = await connection.Collection.UpdateManyAsync(documents, changes);

         Console.WriteLine($" Matched count: {update.MatchedCount},\n Modified count: {update.ModifiedCount} \n Aknowledged: {update.IsAcknowledged}");
    } 
}
