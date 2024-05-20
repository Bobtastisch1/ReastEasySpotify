using Newtonsoft.Json;


namespace ReastEasySpotify.Models
{
    public partial class Playlist
    {
        public class PlaylistDTO
        {
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

        public class ExternalUrls 
        {
            public string spotify { get; set; }
        }

        public class Followers 
        {
            public string href { get; set; }
            public int total { get; set; }
        }

        public class Image 
        {
            public string url { get; set; }
            public int height { get; set; }
            public int width { get; set; }
        }

        public class Owner
        {
            public string display_name { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class Tracks
        {
            public string href { get; set; }
            public List<Items> items { get; set; }
            public int limit { get; set; }
            public string next { get; set; }
            public int offset { get; set; }
            public string previous { get; set; }
            public int total { get; set; }
        }

        public class Items
        {
            public DateTime added_at { get; set; }
            public AddedBy added_by { get; set; }
            public bool is_local { get; set; }
            public bool? primary_color { get; set; }
            public Track track { get; set; }
            public VideoThumbnail video_thumbnail {get;set;}
        }

        public class AddedBy
        {
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string uri { get; set; }

        }

        public class Track
        {
            public Album album { get; set; }
            public List<Artists> artists { get; set; }
            public List<string> available_markets { get; set; }
            public int disc_number { get; set; }
            public bool episode { get; set; }
            [JsonProperty("explicit")]
            public bool Explicit { get; set; }
            public ExternalIds external_Ids { get; set; }
            public ExternalUrls external_Urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public bool? is_local { get; set; }
            public string name { get; set; }
            public int popularity { get; set; }
            public string preview_url { get; set; }
            public bool track {  get; set; }
            public int track_number { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }
        public class Album
        {
            public string album_type { get; set; }
            public List<Artists> artists { get; set; }
            public List<string> available_markets { get; set; }
            public ExternalUrls external_Urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<Image> images { get; set; }
            public string name { get; set; }
            public string release_date { get; set; }
            public string release_date_precision { get; set; }
            public int total_tracks {  get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class AvailableMarkets
        {
            public List<string> available_markets { get; set; }
            public int disc_number { get; set; }
            public float duration_ms { get; set; }
            public bool episode { get; set; }
            [JsonProperty("explicit")]
            public bool Explicit { get; set; }
        }

        public class Artists
        {
            public ExternalUrls external_Urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class ExternalIds
        {
            public string isrc { get; set; }
        }

        public class VideoThumbnail
        {
            public string? url { get; set; }
        }

    }
}
