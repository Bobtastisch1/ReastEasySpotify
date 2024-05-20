using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace ReastEasySpotify.Database.Mongo.Model
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

    }
}
