using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Youtube.Models
{
    public partial class Channel
    {
        public class ChannelDTO
        {
            public Default @default { get; set; }
            public High high { get; set; }
            public Item item { get; set; } 
            public Localized localized { get; set; }
            public Medium medium { get; set; }
            public PageInfo pageInfo { get; set; }
            public Root root { get; set; }
            public Snippet snippet { get; set; }
            public Thumbnails thumbnails { get; set; }
        }

        public class Default
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class High
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string id { get; set; }
            public Snippet snippet { get; set; }
        }

        public class Localized
        {
            public string title { get; set; }
            public string description { get; set; }
        }

        public class Medium
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class PageInfo
        {
            public int totalResults { get; set; }
            public int resultsPerPage { get; set; }
        }

        public class Root
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }

        public class Snippet
        {
            public string title { get; set; }
            public string description { get; set; }
            public string customUrl { get; set; }
            public DateTime publishedAt { get; set; }
            public Thumbnails thumbnails { get; set; }
            public Localized localized { get; set; }
        }

        public class Thumbnails
        {
            public Default @default { get; set; }
            public Medium medium { get; set; }
            public High high { get; set; }
        }

    }
}
