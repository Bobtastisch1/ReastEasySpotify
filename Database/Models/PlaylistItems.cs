using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReastEasySpotify.Database.Models
{

    public class PlaylistItems
    {
        [Key]
        public int Id_PlaylistItems { get; set; }
        public string Href { get; set; }
        public int Limit { get; set; }
        public string Next { get; set; }
        public int Offset { get; set; }
        public string Previous { get; set; }
        public int Total { get; set; }

        // Navigation property for EF Core relationship
        public List<Items> Items { get; set; }
    }

    public class Items
    {
        [Key]
        public int Id_Items { get; set; }

        // Foreign Key
        public int Id_PlaylistItems { get; set; }

        // Navigation property for EF Core relationship
        [ForeignKey("Id_PlaylistItems")]
        public PlaylistItems PlaylistItems { get; set; }

        public DateTime Added_At { get; set; }
        public bool Is_Local { get; set; }
        public bool? Primary_Color { get; set; }

        // Navigation property for EF Core relationship with AddedBy
        public AddedBy AddedBy { get; set; }

        // Change the data type of the foreign key property to match the primary key type of Track
        public int TrackId_Track { get; set; }

        // Navigation property for EF Core relationship with Track
        [ForeignKey("TrackId_Track")]
        public Track Track { get; set; }

        // Change the data type of the foreign key property to match the primary key type of VideoThumbnail
        public int VideoThumbnailId_VideoThumbnail { get; set; }

        // Navigation property for EF Core relationship with VideoThumbnail
        [ForeignKey("VideoThumbnailId_VideoThumbnail")]
        public VideoThumbnail VideoThumbnail { get; set; }
    }

    public class AddedBy
    {
        [Key]
        public int Id_AddedBy { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }

        public ExternalUrls External_Urls { get; set; }

        // Navigation property for EF Core relationship with Items
        public List<Items> Items { get; set; }
    }

    public class Track
    {
        [Key]
        public int Id_Track { get; set; }
        public int AlbumId_Album { get; set; }
        public List<Artists> Artists { get; set; }
        public string Available_Markets { get; set; }
        public int Disc_Number { get; set; }
        public bool Episode { get; set; }
        public bool Explicit { get; set; }
        public int? ExternalIdsId { get; set; }
        public ExternalIds ExternalIds { get; set; }
        public int? ExternalUrlsId { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public bool? Is_Local { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        public string Preview_Url { get; set; }
        public bool track { get; set; }
        public int Track_Number { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class VideoThumbnail
    {
        [Key]
        public int Id_VideoThumbnail { get; set; }
        public string Url { get; set; }

        // Navigation property for EF Core relationship with Items
        public List<Items> Items { get; set; }
    }

    public class Artists
    {
        [Key]
        public int Id_Artists { get; set; }
        public ExternalUrls External_Urls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class ExternalIds
    {
        [Key]
        public int Id_ExternalIds { get; set; }
        public string Isrc { get; set; }
    }

    public class ExternalUrls
    {
        [Key]
        public int Id_ExternalUrls { get; set; }
        public string Spotify { get; set; }
    }

    public class Album
    {
        [Key]
        public int Id_Album { get; set; }
        public string Album_Type { get; set; }
        public List<Artists> Artists { get; set; }
        public string Available_Markets { get; set; }
        public int ExternalUrlsId { get; set; }
        public ExternalUrls ExternalUrls { get; set; }
        public string Href { get; set; }
        public string Id { get; set; }
        public List<Image> Images { get; set; }
        public string Name { get; set; }
        public string Release_Date { get; set; }
        public string Release_Date_Precision { get; set; }
        public int Total_Tracks { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }
    }

    public class Image
    {
        [Key]
        public int Id_Image { get; set; }
        public string Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }

}


