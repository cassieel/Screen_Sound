class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalTime => musics.Sum(m => m.Time);
   

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplaysongsFromAlbum()
    {
        Console.WriteLine($"List of musics from album {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nThe total time of this album is {TotalTime} seconds");
        
    }
}