namespace ReastEasySpotify.Database.Mongo.Model
{
    public partial class Album
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
        public int total_tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
}
