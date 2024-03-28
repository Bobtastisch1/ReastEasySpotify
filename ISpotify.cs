using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ReastEasySpotify.Models;
using RestEase;

namespace ReastEasySpotify
{
    public interface ISpotifyAPI
    {
        [Header("Authorization")]
        AuthenticationHeaderValue Authorization { get; set; }

        [Get("/search")]
        Task<Response<object>> GetSearchAsync([Query("q")] string q,[Query("type")] string type);

        [Get("/playlists/{playlist_id}")]
        Task<Response<object>> GetPlaylistsByIdAsync([Path] string playlist_id);

        [Get("/playlists/{playlist_id}/tracks")]
        Task<Response<object>> GetPlaylistItemsAsync([Path] string playlist_id, int offset);

        //  [Get("/playlist/{playlist_id}/Tracks")]
        //Task<Response> GetPlaylistTracks([Path] string playlist_id);

        //[Get("/additional-services/current-max-sequence")]
        //Task<Response> GetCurrentMaxSequenceAsync();
    }
}