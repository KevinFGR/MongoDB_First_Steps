using System.ComponentModel.DataAnnotations;
using MongoDB.Driver;

namespace MongoDB_First_Steps;

public class connection
{
   public void DB_connect(DB_settings db_Settings){
    string conStr =  db_Settings.Connection_string();
    
   }
}
