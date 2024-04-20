using MongoDB.Bson;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps.Services.CRUD;

public class Create{
    public async Task createUser(){
        try{
            Connection connection = new Connection(); 

            UserModel user = new UserModel{
                Name = "Rexona McLaren",
                Password = "RexMcDonalds",
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
            Connection connection = new Connection(); 

            UserModel[] users = new[]{
                new UserModel{
                    Name = "Darth Veiderson",
                    Password = "TamTamTamTonteramTonteram",
                    BornDate = new DateTime(2000, 3, 20),
                    Age = 24
                },
                new UserModel{
                    Name = "Henzo",
                    Password = "BabyShark24",
                    BornDate = new DateTime(2000, 3,20),
                    Age = 24
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
        try{
            Connection connection = new Connection();

            BsonDocument user1 = new BsonDocument{
                {"Name" , "Kevin Felipe"},
                {"Password" , "MyAdmin123"},
                {"BornDate" , new DateTime(2003, 3,22)},
                {"Age" , 21}
            };
            // To complete this method, you have to change the collection
            // returning type to BsonDocument and uncoment the next line
            // await connection.Collection.InsertOneAsync(user1);
        }catch(Exception e){
            throw new Exception($"Something wrong occurred creating documents. \n {e.Message}");
        }
    }
}