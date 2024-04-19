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
            Console.WriteLine("Document successfuly inserted");

        }catch(Exception e){
            throw new Exception($"There was an error when running the code. \n\n {e.Message}");
        }
    }
    public async Task createManyUsers(){
        // Use InsertMany to insert more than 1 document in the DataBase
        try{
            Connection connection = new Connection("db_test", "db_test_collection");

            UserModel[] users = new[]{
                new UserModel{
                    Name = "Jhon",
                    Password = "jhon@",
                    BornDate = new DateTime(2000, 3, 20),
                    Age = 24
                },
                new UserModel{
                    Name = "Jose",
                    Password = "JosePass",
                    BornDate = new DateTime(1996, 10,10),
                    Age = 27
                }
            };
            await connection.Collection.InsertManyAsync(users);
            Console.WriteLine("Documents successfuly inserted");
            
        }catch(Exception e){
            throw new Exception($"There was an error when running the code. \n\n {e.Message}");
        }
    }


    // If you want to use BsonDocument object type
    public async Task create_Using_BsonDocument(){
        // You have to change the type UserModel to BsonDocument on Connection.cs
        Connection connection = new Connection("db_test","db_test_collection");

        BsonDocument user1 = new BsonDocument{
            {"Name" , "Kevin Felipe"},
            {"Password" , "MyPassword123"},
            {"BornDate" , new DateTime(2003, 3,22)},
            {"Age" , 21}
        };
        // To complete this method, you have to change the collection
        // returning type to BsonDocument and uncoment thennext line
        // await connection.Collection.InsertOneAsync(user1);
    }
}