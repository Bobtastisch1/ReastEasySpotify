using RestEase;

namespace ReastEasySpotify.Youtube
{
    public interface IYoutube
    {

        [Get("/search")]
        Task<Response<object>> GetSearchAsync(string part,string q,string key, string type);

        [Get("/playlists")]
        Task<Response<object>> GetPlaylistAsync(string part, string channelId, string key);

        [Get("/Channels")]
        Task<Response<object>> GetChannelsAsync(string part, string forUserName, string key);
    }
}
