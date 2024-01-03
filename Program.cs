Episode ep1 = new(1, "Discovering The World", 45);
ep1.AddGuests("Jessy");
ep1.AddGuests("James");

Episode ep2 = new(2, "The World of Games", 60);
ep2.AddGuests("Ethan");
ep2.AddGuests("Yennefer");
ep2.AddGuests("Nathan");


Podcast podcast = new("Games House", "Cassiel");
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.DisplayDetails();