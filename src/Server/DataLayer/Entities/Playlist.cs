public class Playlist{
    public int PlaylistId { get; set; }
    public string Name { get; set; }
    public User Author { get; set; }
    public ICollection<Audio> Audios { get; set; }
}