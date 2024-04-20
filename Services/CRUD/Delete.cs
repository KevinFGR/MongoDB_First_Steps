using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.CRUD;

public class Delete{
    public async Task deleteDocument(){
        try{
            Connection connection = new Connection(); 

            FilterDefinition<UserModel> documents = Builders<UserModel>.Filter.Eq("_id", new ObjectId("6620a9123b0b7cffb8868e1f"));

            DeleteResult delete = await connection.Collection.DeleteOneAsync(documents);

            if(delete.IsAcknowledged){
                Console.WriteLine($"Documents deleted: {delete.DeletedCount}");
            }
        }catch(Exception e){
            throw new Exception($"Something wrong occurred deleting documents. \n {e.Message}");
        }
    }
    public async Task deleteManyDocuments(){
        try{
            Connection connection = new Connection(); 

            FilterDefinition<UserModel> documents = Builders<UserModel>.Filter.Gt(d =>d.Age, 22);

            // IF THERE'RE NO PARAMETER IN THE DeleteMany METHOD, ALL DOCUMENTS WILL BE DELETED
            DeleteResult delete = await connection.Collection.DeleteManyAsync(documents);

            if(delete.IsAcknowledged){
                Console.WriteLine($"Documents deleted: {delete.DeletedCount}");
            }
        }catch(Exception e){
            throw new Exception($"Something wrong occurred deleting documents. \n {e.Message}");
        }
    }
}