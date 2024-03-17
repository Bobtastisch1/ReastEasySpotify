using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReastEasySpotify.Models;
using RestEase;

namespace ReastEasySpotify.Controllers
{
    internal class GetPlaylist
    {

        public async Task<Playlist> GetPlaylists(string playlist_id)
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
                Response<object> response = await client.GetPlaylistsByIdAsync(playlist_id);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    Playlist playlistResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Playlist>(response.StringContent);
                    // Parse and return search result
                    Playlist playlist = new Playlist();

                    return playlist;

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
