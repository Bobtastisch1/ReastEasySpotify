﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Youtube.Models
{
    public partial class Search
    {
        public class SearchDTO
        {
            public Default @default { get; set; }
            public High high { get; set; }
            public Id id { get; set; }
            public Medium medium { get; set; }
            public Root root { get; set; }
            public Snippet snippet { get; set; }
            public Thumbnails Thumbnails { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }


        public class Default
        {
            public string url { get; set; }
            public int? width { get; set; }
            public int? height { get; set; }
        }

        public class High
        {
            public string url { get; set; }
            public int? width { get; set; }
            public int? height { get; set; }
        }

        public class Id
        {
            public string kind { get; set; }
            public string? channelId { get; set; }
            public string? videoId { get; set; }
        }

        public class Item
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public Id id { get; set; }
            public Snippet snippet { get; set; }
        }

        public class Medium
        {
            public string url { get; set; }
            public int? width { get; set; }
            public int? height { get; set; }
        }

        public class PageInfo
        {
            public int? totalResults { get; set; }
            public int? resultsPerPage { get; set; }
        }

        public class Root
        {
            public string kind { get; set; }
            public string etag { get; set; }
            public string nextPageToken { get; set; }
            public string regionCode { get; set; }
            public PageInfo pageInfo { get; set; }
            public List<Item> items { get; set; }
        }

        public class Snippet
        {
            public DateTime publishedAt { get; set; }
            public string channelId { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public Thumbnails thumbnails { get; set; }
            public string channelTitle { get; set; }
            public string liveBroadcastContent { get; set; }
            public DateTime publishTime { get; set; }
        }

        public class Thumbnails
        {
            public Default @default { get; set; }
            public Medium medium { get; set; }
            public High high { get; set; }
        }

    }
}
