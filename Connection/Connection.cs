using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_First_Steps.Models;

namespace MongoDB_First_Steps;

public class Connection
{
   public IMongoDatabase Database {get; set;}
   public IMongoCollection<UserModel> Collection {get; set;}
   private string Connection_str {get; set;}

   // DB_settings is a class gitIgnored that contains my connecton string to the Atlas MongoDB
   DB_settings _db_settings = new DB_settings();  

   // Receive a database name and or +collection name , makes the database connection,
   // fills the this.Database and this.Collection content
   public Connection(string db_name) {
      this.Connection_str = _db_settings.Connection_string();

      MongoUrl  mongoUrl = new MongoUrl(this.Connection_str);

      MongoClient mongodb = new MongoClient(mongoUrl);

      this.Database = mongodb.GetDatabase(db_name); 
   }
   public Connection(string db_name, string collection_name) {
      this.Connection_str = _db_settings.Connection_string();

      MongoUrl mongoUrl = new MongoUrl(this.Connection_str);

      MongoClient mongodb = new MongoClient(mongoUrl);

      // if you want a list of all databases you have
      // var databases = mongodb.ListDatabases().ToList(); 

      this.Database = mongodb.GetDatabase(db_name);

      this.Collection = this.Database.GetCollection<UserModel>(collection_name);
    }
}
