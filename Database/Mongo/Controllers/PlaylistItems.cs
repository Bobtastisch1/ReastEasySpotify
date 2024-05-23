using MongoDB.Driver;
using ReastEasySpotify.Database.Mongo.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReastEasySpotify.Models.Playlist;

namespace ReastEasySpotify.Database.Mongo.Controllers
{
    public class PlaylistItems
    {

        public async Task SetPlaylistItems(List<Models.PlaylistItemDTO> playlistItemDTOs)
        {
            MongoSecret mongoSecret = new();

            MongoClient client = new(mongoSecret.ConnectionString());
            IMongoDatabase mongoDb = client.GetDatabase(mongoSecret.GetDatabaseName());

            IMongoCollection<PlaylistItemsDTO> collection = mongoDb.GetCollection<PlaylistItemsDTO>("playlistItems");

            List<PlaylistItemsDTO> playlistItemsDTO = ConvertListModell(playlistItemDTOs);

            foreach (PlaylistItemsDTO playlistItem in playlistItemsDTO)
            {

                var filter = Builders<PlaylistItemsDTO>.Filter.Eq(p => p.id, playlistItem.id);
                var existingPlaylist = await collection.Find(filter).FirstOrDefaultAsync();

                if (existingPlaylist != null)
                {
                    return;
                }

                await collection.InsertOneAsync(playlistItem);

            }
        }

        private List<PlaylistItemsDTO> ConvertListModell(List<PlaylistItemsDTO> playlistItems)
        {
            List<PlaylistItemsDTO> playlistItemDTO = new List<PlaylistItemsDTO>();

            foreach (PlaylistItemsDTO playlistItem in playlistItems)
            {
                playlistItemDTO.Add(ConvertModell(playlistItem));
            }

            return playlistDTO;
        }

        private PlaylistItemsDTO ConvertModell(PlaylistItemsDTO playlistItems)
        {

            return;
        }

    }
}
