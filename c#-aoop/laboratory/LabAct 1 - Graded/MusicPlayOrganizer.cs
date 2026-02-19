using System;

class Song
{
    private string title;
    private string artist;
    private double duration;

    public Song()
    {
        title = "Unknown";
        artist = "Unknown";
        duration = 0.0;
    }

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }
    
    public Song(string title, string artist) : this(title, artist, 0.0)
    {
    }

    public void DisplaySong()
    {
        Console.WriteLine($"Title:      {title,-25}");
        Console.WriteLine($"Artist:     {artist,-25}");
        Console.WriteLine($"Duration (minutes): {duration,5:F2}");
        Console.WriteLine();
    }

    public double GetDuration()
    {
        return duration;
    }

    public void DisplayTableRow()
    {
        Console.WriteLine($"{title,-22} {artist,-22} {duration,5:F2}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Songs to add: ");
        int songCount = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Song[] playlist = new Song[songCount];
        for (int i = 0; i < songCount; i++)
        {
            Console.WriteLine($"Song #{i + 1}:");
            Console.Write("Title:   ");
            string title = Console.ReaLine();
            Console.Write("Artist:  ");
            string artist = Console.ReadLine();
            Console.Write("Duration (minutes):  ");
            double duration = double.Parse(Console.ReadLine());

            playlist[i] = new Song(title, artist, duration);
            Console.WriteLine();
        }

        Console.WriteLine("=== || MY PLAYLIST || ===");
        Console.WriteLine("Title".PadRight(26) + "Artist".Padright(23) + "Time");
        Console.WriteLine(new string('-', 26 + 23 + 6));
        double totalDuration = 0.0;

        foreach (Song song in playlist)
        {
            song.DisplayTableRow();
            totalDuration += song.GetDuration();
        }
        Console.WriteLine();
        double average = totalDuration / songCount;
        Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {average:F2} mins");
    }
}