using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_First_Steps.Models
{
    public class UserModel
    // a model of a database I will create to make the others methods of CRUD
    {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id {get;set;}

    [BsonElement("Name")]
    public string Name { get; set; }

    [BsonElement("Password")]
    public string Password { get; set; }

    [BsonElement("BornDate")]
    public DateTime BornDate { get; set; }

    // I know age is not a good var couse its changes through the years. I just want an INT atribute
    [BsonElement("Age")]
    public int Age { get; set; }
    }
}