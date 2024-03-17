using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReastEasySpotify.Models
{

    public partial class Search
    {

        public class SearchDTO
        {
            public PlaylistsType Playlists { get; set; }
        }

        public class PlaylistsType
        {
            public string href { get; set; }
            public List<PlaylistItem> items { get; set; }
            public int limit { get; set; }
            public string next { get; set; }
            public int offset { get; set; }
            public int? previous { get; set; }
            public int total { get; set; }
        }

        public class PlaylistItem
        {
            public bool collaborative { get; set; }
            public string description { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<Image> images { get; set; }
            public string name { get; set; }
            public PlaylistOwner owner { get; set; }
            public string? primary_color { get; set; }
            [JsonProperty("public")]
            public bool? Public {  get; set; }
            public string snapshot_id { get; set; }
            public PlaylistTracks tracks { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }

        public class PlaylistOwner
        {
            public string display_name { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }
        public class PlaylistTracks
        {
            public string href { get; set; }
            public int total { get; set; }
        }

        public class ExternalUrls
        {
            public string spotify { get; set; }
        }

        public class Image
        {
            public string url { get; set; }
            public int? height { get; set; }
            public int? width { get; set; }
        }
    }
}
