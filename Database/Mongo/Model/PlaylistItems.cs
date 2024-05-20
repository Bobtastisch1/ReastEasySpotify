using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ReastEasySpotify.Database.Mongo.Model
{
    public partial class PlaylistItems
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Items> items { get; set; }
    }
}

