using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.CRUD;
public class Read
{
    // accessing the sample_mflix database and returning some regisers
    public async Task readCollection(){
        try{
            Connection connection = new Connection();  

            // the expression (_=>true) will return all documents in the colllection
            // If you want something more specifically you also can. Example: (d =>d.Name = "Jose") 
            List<UserModel> documents =  await connection.Collection.Find(_ => true).ToListAsync();

            foreach(var d in documents){
                Console.WriteLine(d.ToJson());
            }
        }catch(Exception e){
            throw new Exception($"Something wrong occurred reading documents. \n {e.Message}");
        }
    }
    public async Task read_collection_using_mongoBuilder(){
        // Using Mongo Bilder query
        try{
            Connection connection = new Connection(); 
            
            FilterDefinition<UserModel> query = Builders<UserModel>.Filter.Eq("name", "Kevin Felipe");

            List<UserModel> documents = await connection.Collection.Find(query).ToListAsync();

            foreach(var d in documents){
                Console.WriteLine(d.ToJson());
            }
        }catch(Exception e){
            throw new Exception($"Something wrong occurred reading documents. \n {e.Message}");
        }
    }

}
        
