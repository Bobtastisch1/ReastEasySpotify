
using Newtonsoft.Json;

namespace ReastEasySpotify.Database.Mongo.Model
{
    public partial class Track
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
        public bool track { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
}
