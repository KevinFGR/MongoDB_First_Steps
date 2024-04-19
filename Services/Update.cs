using System.ComponentModel;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services;

public class Update
{
    public async Task updateDocument(){
        try{
            Connection connection = new Connection("db_test", "db_test_collection");
            
            FilterDefinition<UserModel> filter = Builders<UserModel>.Filter.Eq(d => d.Age, 68);

            UpdateDefinition<UserModel> document = Builders<UserModel>.Update.Set(d=>d.Password, "An_Old_Guy");

            UpdateResult update = await connection.Collection.UpdateOneAsync(filter, document);

            // The IsAcknowledged return true if the database operation was successfully completed
            if(update.IsAcknowledged){
                Console.WriteLine($" Matched count: {update.MatchedCount},\n Modified count: {update.ModifiedCount}");
            }
        }catch(Exception e){
            throw new Exception($"Something wrong occurred updating document. \n {e.Message}");
        }
    }

    public async Task updateManyDocuments(){
        try{
            Connection connection = new Connection("db_test", "db_test_collection");

            FilterDefinition<UserModel> documents = Builders<UserModel>.Filter.Lt(d=>d.Age, 60);

            // Incrementing 20 years in the Age key
            UpdateDefinition<UserModel> changes = Builders<UserModel>.Update.Inc(d=>d.Age, 20);

            UpdateResult update = await connection.Collection.UpdateManyAsync(documents, changes);

            if(update.IsAcknowledged){
                Console.WriteLine($" Matched count: {update.MatchedCount},\n Modified count: {update.ModifiedCount}");
            }
        }catch(Exception e){
            throw new Exception($"Something wrong occurred updating documents. \n {e.Message}");
        }
    } 
}
