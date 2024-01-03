class Podcast
{
    private List<Episode> episodes = new();

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Podcast {Name} presented by {Host}\n");
        foreach (Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Resume);
        }
        Console.WriteLine($"\n\nTotal of episodes: {TotalEpisodes} episodes.");
    }
}