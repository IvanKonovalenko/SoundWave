public class Audio{
    public int AudioId { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public User Author { get; set; }
    public ICollection<Playlist> Playlists { get; set; }

}