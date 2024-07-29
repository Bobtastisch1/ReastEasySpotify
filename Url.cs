using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ReastEasySpotify
{
    internal class Url
    {
        private string baseSpotifyUrl = "https://api.spotify.com/v1/";
        private string baseYoutubeUrl = "https://www.googleapis.com/youtube/v3";

        public string GetBaseSpotifyUrl() {  return baseSpotifyUrl; }

        public string GetBaseYoutubeUrl() { return baseYoutubeUrl; }
    }
}
