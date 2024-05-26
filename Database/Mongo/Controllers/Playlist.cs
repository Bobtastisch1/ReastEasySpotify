using MongoDB.Driver;
using ReastEasySpotify.Database.Mongo.Model.DTO;

namespace ReastEasySpotify.Database.Mongo.Controllers
{
    public class Playlist
    {


        public async Task SavePlaylistInMongo(Models.Playlist.PlaylistDTO playlistDTO)
        {
            MongoDbHelper<PlaylistDTO> mongoDbHelper = new("playlist");
            IMongoCollection<PlaylistDTO> collection = mongoDbHelper.GetCollection();

            PlaylistDTO playlistItemsDTO = ConvertModell(playlistDTO);

            var filter = Builders<PlaylistDTO>.Filter.Eq(p => p.id, playlistItemsDTO.id);
            var existingPlaylist = await collection.Find(filter).FirstOrDefaultAsync();

            if (existingPlaylist != null)
            {
                return;
            }

            await collection.InsertOneAsync(playlistItemsDTO);                
        }


        private PlaylistDTO ConvertModell(Models.Playlist.PlaylistDTO playlistDTO)
        {
            PlaylistDTO playlistItemsDTO = new PlaylistDTO
            {
                collaborative = playlistDTO.collaborative,
                description = playlistDTO.description,
                external_urls = new Model.ExternalUrls
                {
                    spotify = playlistDTO.external_urls.spotify
                },
                followers = new Model.Followers
                {
                    href = playlistDTO.followers.href,
                    total = playlistDTO.followers.total
                },
                href = playlistDTO.href,
                id = playlistDTO.id,
                images = playlistDTO.images.Select(img => new Model.Image
                {
                    height = img.height,
                    url = img.url,
                    width = img.width
                }).ToList(),
                name = playlistDTO.name,
                owner = new Model.Owner
                {
                    display_name = playlistDTO.owner.display_name,
                    external_urls = new Model.ExternalUrls
                    {
                        spotify = playlistDTO.external_urls.spotify,
                    },
                    href = playlistDTO.owner.href,
                    id = playlistDTO.owner.id,
                    type = playlistDTO.owner.type,
                    uri = playlistDTO.owner.uri,
                },
                primary_color = playlistDTO.primary_color,
                Public = playlistDTO.Public,
                snapshot_id = playlistDTO.snapshot_id,
                tracks = new Model.Tracks
                {
                    href = playlistDTO.tracks.href,
                    items = playlistDTO.tracks.items.Select(item => new Model.Items
                    {
                        added_at = item.added_at,
                        added_by = new Model.AddedBy
                        {
                            external_urls = new Model.ExternalUrls
                            {
                                spotify = item.added_by.external_urls.spotify,
                            },
                            href = item.added_by.href,
                            id = item.added_by.id,
                            type = item.added_by.type,
                            uri = item.added_by.uri,
                        },
                        is_local = item.is_local,
                        primary_color = item.primary_color,
                        track = new Model.Track
                        {
                            album = new Model.Album
                            {
                                album_type = item.track.album.album_type,
                                artists = item.track.album.artists.Select(artist => new Model.Artists
                                {
                                    external_Urls = new Model.ExternalUrls
                                    {
                                        spotify = artist.external_Urls.spotify
                                    },
                                    href = artist.href,
                                    id = artist.id,
                                    name = artist.name,
                                    type = artist.type,
                                    uri = artist.uri
                                }).ToList(),
                                available_markets = item.track.album.available_markets,
                                external_Urls = new Model.ExternalUrls
                                {
                                    spotify = item.track.album.external_Urls.spotify
                                },
                                href = item.track.album.href,
                                id = item.track.album.id,
                                images = item.track.album.images.Select(img => new Model.Image
                                {
                                    height = img.height,
                                    url = img.url,
                                    width = img.width
                                }).ToList(),
                                name = item.track.album.name,
                                release_date = item.track.album.release_date,
                                release_date_precision = item.track.album.release_date_precision,
                                total_tracks = item.track.album.total_tracks,
                                type = item.track.album.type,
                                uri = item.track.album.uri
                            },
                            artists = item.track.artists.Select(artist => new Model.Artists
                            {
                                external_Urls = new Model.ExternalUrls
                                {
                                    spotify = artist.external_Urls.spotify
                                },
                                href = artist.href,
                                id = artist.id,
                                name = artist.name,
                                type = artist.type,
                                uri = artist.uri
                            }).ToList(),
                            available_markets = item.track.available_markets,
                            disc_number = item.track.disc_number,
                            episode = item.track.episode,
                            Explicit = item.track.Explicit,
                            external_Ids = new Model.ExternalIds
                            {
                                isrc = item.track.external_Ids.isrc
                            },
                            external_Urls = new Model.ExternalUrls
                            {
                                spotify = item.track.external_Urls.spotify
                            },
                            href = item.track.href,
                            id = item.track.id,
                            is_local = item.track.is_local,
                            name = item.track.name,
                            popularity = item.track.popularity,
                            preview_url = item.track.preview_url,
                            track = item.track.track,
                            track_number = item.track.track_number,
                            type = item.track.type,
                            uri = item.track.uri
                        },
                        video_thumbnail = new Model.VideoThumbnail
                        {
                            url = item.video_thumbnail.url
                        }
                    }).ToList(),
                    limit = playlistDTO.tracks.limit,
                    next = playlistDTO.tracks.next,
                    offset = playlistDTO.tracks.offset,
                    previous = playlistDTO.tracks.previous,
                    total = playlistDTO.tracks.total,
                },
                type = playlistDTO.type,
                uri = playlistDTO.uri
            };

            return playlistItemsDTO;
        }
    }
} 