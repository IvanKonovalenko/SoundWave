using Microsoft.EntityFrameworkCore;

public class AppDbContext:DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Audio> Audios { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
}