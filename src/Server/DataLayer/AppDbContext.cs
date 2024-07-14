using Microsoft.EntityFrameworkCore;

public class AppDbContext:DbContext{
    public DbSet<User> Users { get; set; }
    public DbSet<Audio> Audios { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
}