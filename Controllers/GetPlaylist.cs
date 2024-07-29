using ReastEasySpotify.Models;
using RestEase;


namespace ReastEasySpotify.Controllers
{
    internal class GetPlaylist
    {

        public async Task<Playlist.PlaylistDTO> GetPlaylists(string playlist_id)
        {
            Url baseUrl = new();
            string url = baseUrl.GetBaseSpotifyUrl();

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
                    Playlist.PlaylistDTO playlistResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Playlist.PlaylistDTO>(response.StringContent);
                    // Parse and return search result                  

                    return playlistResponse;

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
