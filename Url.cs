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
        private String baseUrl = "https://api.spotify.com/v1/";

        public string GetUrl(string param)
        {
            string url = baseUrl + param;

            return url;
        }

        public string GetBaseUrl() {  return baseUrl; }

    }
}
