using Microsoft.EntityFrameworkCore;
using ReastEasySpotify.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Database
{
    public class SpotifyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=" + DBSecrets.GetDbServer() + ";Database=" + DBSecrets.GetDbName() + ";Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

        }
        //Deffine the Tables 
        //Like: public DbSet<User> User { get; set; }

        public DbSet<PlaylistItems> PlaylistItems { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<AddedBy> AddedBy { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<VideoThumbnail> VideoThumbnails { get; set; }
        public DbSet<Artists> Artists { get; set; }
        public DbSet<ExternalIds> ExternalIds { get; set; }
        public DbSet<ExternalUrls> ExternalUrls { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Image> Images { get; set; }

        //Package Manager Console = Add-Migration (Name What you did)
        //Package Manager Console = Update-Database (To Save the Changes on the DB)
    }
}
