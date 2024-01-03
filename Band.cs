class Band
{
    private List<Album> albums = new List<Album>();

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ViewDiscography()
    {
        Console.WriteLine($"Discography of band {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"album: {album.Name} ({album.TotalTime})");
        }
    }
}