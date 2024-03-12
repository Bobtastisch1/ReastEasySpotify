using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReastEasySpotify.Models
{

    internal class SearchDTO
    {
        public Album album { get; set; }
        public Albums albums { get; set; }
        public Artist artist { get; set; }
        public Audiobooks audiobooks { get; set; }
        public Author author { get; set; }
        public Copyright copyright { get; set; }
        public Episodes episodes { get; set; }
        public ExternalIds externalIds { get; set; }
        public ExternalUrls externalUrls { get; set; }
        public Followers followers { get; set; }
        public Image image { get; set; }
        public Item item { get; set; }
        public LinkedFrom linkedFrom { get; set; }
        public Narrator narrator { get; set; }
        public Owner owner { get; set; }
        public Playlists playlists { get; set; }
        public Restrictions restrictions { get; set; }
        public ResumePoint resumePoint { get; set; }
        public Root root { get; set; }
        public Shows shows { get; set; }
        public Tracks tracks { get; set; }
    }

    internal class Album
    {
        public string album_type { get; set; }
        public int total_tracks { get; set; }
        public List<string> available_markets { get; set; }
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public List<Image> images { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public Restrictions restrictions { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public List<Artist> artists { get; set; }
    }
    internal class Albums
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }

    internal class Artist
    {
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public Followers followers { get; set; }
        public List<string> genres { get; set; }
        public List<Image> images { get; set; }
        public int popularity { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }
    internal class Audiobooks
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }
    internal class Author
    {
        public string name { get; set; }
    }
    internal class Copyright
    {
        public string text { get; set; }
        public string type { get; set; }
    }
    internal class Episodes
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }
    internal class ExternalIds
    {
        public string isrc { get; set; }
        public string ean { get; set; }
        public string upc { get; set; }
    }
    internal class ExternalUrls
    {
        public string spotify { get; set; }
    }
    public class Followers
    {
        public string href { get; set; }
        public int total { get; set; }
    }
    internal class Image
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
    internal class Item
    {
        public Album album { get; set; }
        public List<Artist> artists { get; set; }
        public List<string> available_markets { get; set; }
        public int disc_number { get; set; }
        public int duration_ms { get; set; }
        public bool @explicit { get; set; }
        public ExternalIds external_ids { get; set; }
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public bool is_playable { get; set; }
        public LinkedFrom linked_from { get; set; }
        public Restrictions restrictions { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string preview_url { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public bool is_local { get; set; }
        public Followers followers { get; set; }
        public List<string> genres { get; set; }
        public List<Image> images { get; set; }
        public string album_type { get; set; }
        public int total_tracks { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public bool collaborative { get; set; }
        public string description { get; set; }
        public Owner owner { get; set; }
        public bool @public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public List<Copyright> copyrights { get; set; }
        public string html_description { get; set; }
        public bool is_externally_hosted { get; set; }
        public List<string> languages { get; set; }
        public string media_type { get; set; }
        public string publisher { get; set; }
        public int total_episodes { get; set; }
        public string audio_preview_url { get; set; }
        public string language { get; set; }
        public ResumePoint resume_point { get; set; }
        public List<Author> authors { get; set; }
        public string edition { get; set; }
        public List<Narrator> narrators { get; set; }
        public int total_chapters { get; set; }
    }
    internal class LinkedFrom
    {
    }

    internal class Narrator
    {
        public string name { get; set; }
    }
    internal class Owner
    {
        public ExternalUrls external_urls { get; set; }
        public Followers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public string display_name { get; set; }
    }
    internal class Playlists
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }
    internal class Restrictions
    {
        public string reason { get; set; }
    }
    internal class ResumePoint
    {
        public bool fully_played { get; set; }
        public int resume_position_ms { get; set; }
    }
    internal class Root
    {
        public Tracks tracks { get; set; }
        public Artist artists { get; set; } // Koente Probleme Machen Model Sagt "Artists" doch nur "Artist" ist hier vorhanden
        public Albums albums { get; set; }
        public Playlists playlists { get; set; }
        public Shows shows { get; set; }
        public Episodes episodes { get; set; }
        public Audiobooks audiobooks { get; set; }
    }
    internal class Shows
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }
    internal class Tracks
    {
        public string href { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public int total { get; set; }
        public List<Item> items { get; set; }
    }

}
