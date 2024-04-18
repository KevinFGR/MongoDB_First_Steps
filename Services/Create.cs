using MongoDB.Bson;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services;

public class Create{


    public async Task createUser(){
        try{
            Connection connection = new Connection("db_test", "db_test_collection");

            UserModel user = new UserModel{
                Name = "Felipe Kevin",
                Password = "admin@admin",
                BornDate = new DateTime(1955, 6, 18),
                Age = 68
            };

            await connection.Collection.InsertOneAsync(user);
        }catch(Exception e){
            Console.WriteLine($"There was an error when running the code. \n\n {e}");
        }
    }

    // public async Task create_Using_BsonDocument(){
        // You have to change the type UserModel to BsonDocument on Connection.cs
    //     Connection connection = new Connection("db_test","db_test_collection");

    //     BsonDocument user1 = new BsonDocument{
    //         {"Name" , "Kevin Felipe"},
    //         {"Password" , "MyPassword123"},
    //         {"BornDate" , new DateTime(2003, 3,22)},
    //         {"Age" , 21}
    //     };
    //     await connection.Collection.InsertOneAsync(user1);
    // }
}