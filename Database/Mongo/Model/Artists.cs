﻿namespace ReastEasySpotify.Database.Mongo.Model
{
    public partial class Artists
    {
        public ExternalUrls external_Urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
}
