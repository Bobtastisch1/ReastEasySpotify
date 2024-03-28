using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReastEasySpotify.Models.Playlist;

namespace ReastEasySpotify.Models
{
    public partial class PlaylistItem
    {
        public class PlaylistItemDTO
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
}
