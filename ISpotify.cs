using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestEase;

namespace ReastEasySpotify
{
    public interface ISpotifyAPI
    {
        [Header("Authorization")]
        AuthenticationHeaderValue Authorization { get; set; }

        [Header("X-Api-Key")]
        string APIKey { get; set; }

        [Get("/search")]
        Task<Response> GetSearch();

        [Get("/playlist/{playlist_id}")]
        Task<Response> GetPlaylistById([Path] string playlist_id);

        [Get("/playlist/{playlist_id}/Tracks")]
        Task<Response> GetPlaylistTracks([Path] string playlist_id);

        //[Get("/additional-services/current-max-sequence")]
        //Task<Response> GetCurrentMaxSequenceAsync();
    }

    public class Response
    {
    }
}
