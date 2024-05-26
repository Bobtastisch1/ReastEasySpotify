using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ReastEasySpotify.Database.Mongo.Model.DTO
{
    public partial class PlaylistItemDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string playlistItemId { get; set; }

        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Items> items { get; set; }

    }
}
