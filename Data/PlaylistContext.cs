using Microsoft.EntityFrameworkCore;
using PlaylistAPI.Models;
namespace PlaylistAPI.Data{

    public class PlaylistContext : DbContext
    {
        //constructor 
        public PlaylistContext(DbContextOptions<PlaylistContext> options) : base(options)
        {
        }

        public DbSet<Song>? Songs { get; set; }
        public DbSet<Genre>? Genres { get; set; }
    }
}