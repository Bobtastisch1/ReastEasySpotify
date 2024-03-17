using System.Net;
using ReastEasySpotify;
using ReastEasySpotify.Controllers;
using ReastEasySpotify.Models;
using static ReastEasySpotify.Models.Search;

namespace ReastEasySpotify
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
;

            GetSearch getSearch = new();

            SearchDTO c = await getSearch.GetSearchs("Masse x Gewicht", "playlist");
      
            Console.WriteLine(c.Playlists.href);

        }

    }
}
