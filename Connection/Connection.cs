using MongoDB.Driver;

namespace MongoDB_First_Steps;

public class Connection
{

   // Receive a database name, makes the database connection
   //  and return the database received 
   public IMongoDatabase DB_connect(string db_name){
      // DB_settings is a class gitIgnored that contains my connecton string to the Atlas MongoDB
      DB_settings _db_settings = new DB_settings();  

      string connection_string =  _db_settings.Connection_string();

      MongoUrl mongoUrl = new MongoUrl(connection_string);

      MongoClient mongodb = new MongoClient(mongoUrl);

      // if you want a list of all databases you have
      // var databases = mongodb.ListDatabases().ToList(); 

      IMongoDatabase database = mongodb.GetDatabase(db_name);

      return database;

   }
}
