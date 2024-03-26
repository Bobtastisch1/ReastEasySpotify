using System.Net;
using Newtonsoft.Json;
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

            SearchDTO searchDTO = await getSearch.GetSearchs("Masse x Gewicht", "playlist");

            Program program = new Program();
            program.WriteSearchDTOToFile(searchDTO, "Seach_Playlist.json");
        }

        public void WriteSearchDTOToFile(SearchDTO searchDTO, string fileName)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(searchDTO, Newtonsoft.Json.Formatting.Indented);
            
            string directory = Directory.GetCurrentDirectory();

            string filePath = Path.Combine(directory, fileName);
            try
            {
                File.WriteAllText(filePath, json);              
            }catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
