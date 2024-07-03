using MongoDB.Driver;
using ReastEasySpotify.Database.Mongo.Model;
using ReastEasySpotify.Database.Mongo.Model.DTO;


namespace ReastEasySpotify.Database.Mongo.Controllers
{
    public class Track
    {
        public async Task SaveTrackInMongo(PlaylistItemDTO playlistItem)
        {
            MongoDbHelper<TrackDTO> mongoDbHelper = new("Tracks");
            IMongoCollection<TrackDTO> collection = mongoDbHelper.GetCollection();

            List<TrackDTO> tracks =  ConvertPlaylistItemToTrack(playlistItem);

            foreach( TrackDTO track in tracks )
            {
                var filter = Builders<TrackDTO>.Filter.Eq(p => p.track.id, track.track.id);
                var existingTrack = await collection.Find(filter).FirstOrDefaultAsync();

                if (existingTrack != null)
                {
                    continue;
                }

                await collection.InsertOneAsync(track);

            }

        }


        private List<TrackDTO> ConvertPlaylistItemToTrack(PlaylistItemDTO playlistItem)
        {
            List<TrackDTO> tracks = new List<TrackDTO>();
            foreach( Model.Items item in playlistItem.items)
            {

                TrackDTO track = new TrackDTO()
                {
                    added_at = item.added_at,
                    added_by = new AddedBy
                    {
                        external_urls = new ExternalUrls
                        {
                            spotify = item.added_by.external_urls.spotify
                        },
                        href = item.added_by.href,
                        id = item.added_by.id,
                        type = item.added_by.type,
                        uri = item.added_by.uri
                    },
                    is_local = item.is_local,
                    primary_color = item.primary_color,
                    track = new Model.Track
                    {
                        album = new Album
                        {
                            album_type = item.track.album.album_type,
                            artists = item.track.album.artists.Select(artist => new Artists
                            {
                                external_Urls = new ExternalUrls
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
                            external_Urls = new ExternalUrls
                            {
                                spotify = item.track.album.external_Urls.spotify
                            },
                            href = item.track.album.href,
                            id = item.track.album.id,
                            images = item.track.album.images.Select(image => new Image
                            {
                                url = image.url,
                                height = image.height,
                                width = image.width
                            }).ToList(),
                            name = item.track.album.name,
                            release_date = item.track.album.release_date,
                            release_date_precision = item.track.album.release_date_precision,
                            total_tracks = item.track.album.total_tracks,
                            type = item.track.album.type,
                            uri = item.track.album.uri
                        },
                        artists = item.track.artists.Select(artist => new Artists
                        {
                            external_Urls = new ExternalUrls
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
                        external_Urls = new ExternalUrls
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
                    video_thumbnail = new VideoThumbnail
                    {
                        url = item.video_thumbnail.url
                    }
                };


                tracks.Add(track);
            }

            return tracks;
        }
    }
}
