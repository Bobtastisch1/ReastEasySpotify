using ReastEasySpotify.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ReastEasySpotify.Models.PlaylistItem;

namespace ReastEasySpotify.Database
{
    public class ServiceDB
    {

        public void ServiceDataBase(List<PlaylistItemDTO> playlistItemDB)
        {
            var context = new SpotifyContext();

            foreach (PlaylistItemDTO playlistDTO in playlistItemDB)
            {
                var playlistItem = new PlaylistItems
                {
                    Href = playlistDTO.href != null ? playlistDTO.href : "",
                    Next = playlistDTO.next != null ? playlistDTO.next : "",
                    Previous = playlistDTO.previous != null ? playlistDTO.previous : "", // Handle null case
                    Total = playlistDTO.total != null ? playlistDTO.total : 0,
                    Offset = playlistDTO.offset != null ? playlistDTO.offset : 0,
                    Limit = playlistDTO.limit != null ? playlistDTO.limit : 0
                };

                foreach (var item in playlistDTO.items)
                {
                    playlistItem.Items.Add(new Items
                    {
                        Added_At = item.added_at,
                        //AddedBy = item.added_by,
                        Is_Local = item.is_local,
                        Primary_Color = item.primary_color,
                        TrackId_Track = context.Tracks.FirstOrDefault(t => t.Name == item.track.name)?.Id_Track ?? 0,
                        VideoThumbnailId_VideoThumbnail = context.VideoThumbnails.FirstOrDefault(vt => vt.Url == item.video_thumbnail.url)?.Id_VideoThumbnail ?? 0
                    });
                }

                context.PlaylistItems.Add(playlistItem);
            }

            context.SaveChanges();
        }

    }
}
