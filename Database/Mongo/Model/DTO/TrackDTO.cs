using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace ReastEasySpotify.Database.Mongo.Model.DTO
{
    public partial class TrackDTO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TrackId { get; set; }

        public DateTime added_at { get; set; }
        public AddedBy added_by { get; set; }
        public bool is_local { get; set; }
        public bool? primary_color { get; set; }
        public Track track { get; set; }
        public VideoThumbnail video_thumbnail { get; set; }
    }
}
