
using RestEase;


namespace ReastEasySpotify.Youtube.Controllers
{
	internal class GetPlaylist()
	{
        public async Task<Models.Playlist.PlaylistDTO> GetPlaylists(string part, string channelId, string PlaylistName)
        {
            Url baseUrl = new();
            string url = baseUrl.GetBaseYoutubeUrl();

            IYoutube youtube = RestClient.For<IYoutube>(url);

            try
            {
                Response<object> response = await youtube.GetPlaylistAsync(part, channelId, YoutubeSecret.GetApiKey());

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    Models.Playlist.PlaylistDTO? playlistDTO = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Playlist.PlaylistDTO>(response.StringContent);

                    if (playlistDTO.items != null)
                    {
                        foreach (Models.Playlist.Item playlistItem in playlistDTO.items)
                        {
                            if (playlistItem.snippet.title == PlaylistName)
                            {
                                return playlistDTO;
                            }
                        }
                    }                   

                    return playlistDTO;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
