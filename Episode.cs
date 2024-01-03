class Episode
{
    private List<string> guests = new();
    public Episode(int ordem, string title, int time)
    {
        Order = ordem;
        Title = title;
        Time = time;
    }

    public int Order { get; }
    public string Title { get; }
    public int Time { get; }
    public string Resume => $"{Order}. {Title} ({Time} min) - {
        string.Join (", ", guests)}";

    public void AddGuests(string guest)
    {
        guests.Add(guest);
    }
}