using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReastEasySpotify.Models;
using RestEase;
using static ReastEasySpotify.Models.PlaylistItem;

namespace ReastEasySpotify.Controllers
{
    internal class GetPlaylistItem
    {
        public async Task<PlaylistItemDTO> GetPlaylistsItems(string playlist_id, int offset)
        {
            Url baseUrl = new();
            string url = baseUrl.GetBaseUrl();

            ISpotifyAPI client = RestClient.For<ISpotifyAPI>(url);

            GetTokenQuery GetToken = new();
            string token = GetToken.SetAuthorization();

            if (string.IsNullOrWhiteSpace(token))
            {
                // Handle error or return null
                return null;
            }

            client.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            try
            {
                Response<object> response = await client.GetPlaylistItemsAsync(playlist_id, offset);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    PlaylistItemDTO playlistItemResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<PlaylistItemDTO>(response.StringContent);
                    // Parse and return search result

                    return playlistItemResponse;

                }
                else
                {

                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        
        }
    }
}
