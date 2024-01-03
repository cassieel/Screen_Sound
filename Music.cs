class Music
{
    public Music(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name {  get; }
    public Band Artist { get; }
    public int Time { get; set; }
    public bool Available { get; set; }
    
    public string ResumeDescription => $"The song {Name} belongs to the artist {Artist}";

    public void ViewTechnicalSheet()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Time: {Time}");
        if (Available)
        {
            Console.WriteLine("Available in the Plan.");
        } else
        {
            Console.WriteLine("Adquire the Plan Plus to listen this music.");
        }
    }

    public void ViewNameAndArtist()
    {
        Console.WriteLine($"Name/Artist: {Name} - {Artist}");
    }
}

