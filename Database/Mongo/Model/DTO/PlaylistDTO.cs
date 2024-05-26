using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace ReastEasySpotify.Database.Mongo.Model.DTO
{
    public partial class PlaylistDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string playlistId { get; set; }


        public bool collaborative { get; set; }
        public string description { get; set; }
        public ExternalUrls external_urls { get; set; }
        public Followers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public List<Image> images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public bool? primary_color { get; set; }
        [JsonProperty("public")]
        public bool? Public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
}
