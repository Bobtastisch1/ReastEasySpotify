using ReastEasySpotify.Controllers;
using ReastEasySpotify.Models;


namespace ReastEasySpotify
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Program program = new Program();

            Youtube.Controllers.GetSearch YouSearch = new();

            Youtube.Models.Search.SearchDTO search = await YouSearch.GetSearches("snippet", "Bobs Music to mutch to handle for you", "");

            Youtube.Controllers.GetPlaylist YouPlaylist = new();

            await YouPlaylist.GetPlaylists("snippet", search.items.First().snippet.channelId, "OnlyBobs");



            //GetSearch getSearch = new();

            //Search.SearchDTO searchDTO = await getSearch.GetSearchs("Masse x Gewicht", "playlist");

            //GetPlaylist getPlaylist = new();

            //Playlist.PlaylistDTO playlistDTO = await getPlaylist.GetPlaylists(searchDTO.Playlists.items.First().id);

            //Database.Mongo.Controllers.Playlist MongoPlaylist = new ();

            //await MongoPlaylist.SavePlaylistInMongo(playlistDTO);

            //Task<List<PlaylistItemDTO>> playlistItems = program.GetAllTracksFromPlaylist(playlistDTO.id);

            //Database.Mongo.Controllers.PlaylistItems MongoPlaylistItems = new ();

            //await MongoPlaylistItems.SaveItemsFromPlaylistInMongo(await playlistItems);



        }

        public async Task<List<PlaylistItemDTO>> GetAllTracksFromPlaylist(string playlist_id)
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
