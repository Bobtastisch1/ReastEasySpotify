using System.Net;
using Newtonsoft.Json;
using ReastEasySpotify;
using ReastEasySpotify.Controllers;
using ReastEasySpotify.Models;
using static ReastEasySpotify.Models.Search;
using static ReastEasySpotify.Models.Playlist;
using static ReastEasySpotify.Models.PlaylistItem;

namespace ReastEasySpotify
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            GetSearch getSearch = new();

            SearchDTO searchDTO = await getSearch.GetSearchs("Masse x Gewicht", "playlist");

            GetPlaylist getPlaylist = new();

            PlaylistDTO playlistDTO = await getPlaylist.GetPlaylists(searchDTO.Playlists.items.First().id);

           

            Program program = new Program();
            Task<List<PlaylistItemDTO>> playlistItems = program.GetAllTracksInPlaylist(playlistDTO.id);

            program.WriteSearchDTOToFile(playlistItems.Result, "PlaylistItems.json");
            program.WriteSearchDTOToFile(searchDTO, "Seach_Playlist.json");
            program.WriteSearchDTOToFile(playlistDTO, "Playlist.json");
        }

        public void WriteSearchDTOToFile(object searchDTO, string fileName)
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

        public async Task<List<PlaylistItemDTO>> GetAllTracksInPlaylist(string playlist_id)
        {
            int total = 1;
            int offset = 0;
            List<PlaylistItemDTO> playlistItems = new List<PlaylistItemDTO>();
            GetPlaylistItem getPlaylistItem = new();

            while(offset < total)
            {
                PlaylistItemDTO playlistItemDTO = await getPlaylistItem.GetPlaylistsItems(playlist_id, offset);
                total = playlistItemDTO.total;
                playlistItems.Add(playlistItemDTO);
                offset += 100;
            }

            return playlistItems;
        }

    }
}
