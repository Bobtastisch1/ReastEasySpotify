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

        //[Get("/search/?q={q}&type={type}")]
        [Get("/search")]
        Task<Response<object>> GetSearchAsync([Query("q")] string q,
                                          [Query("type")] string type);


        //  [Get("/playlist/{playlist_id}")]
        //'Task<Response> GetPlaylistById([Path] string playlist_id);

        //  [Get("/playlist/{playlist_id}/Tracks")]
        //Task<Response> GetPlaylistTracks([Path] string playlist_id);

        //[Get("/additional-services/current-max-sequence")]
        //Task<Response> GetCurrentMaxSequenceAsync();
    }
}