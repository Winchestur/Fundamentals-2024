using System.ComponentModel;
using System.Numerics;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < counter; i++)
        {
            List<string> data = Console.ReadLine().Split("_").ToList();

            string typelist = data[0];
            string name = data[1];
            string time = data[2];

            Song song = new Song();

            song.TypeList = typelist;
            song.Name = name;
            song.Time = time;

            songs.Add(song);
        }

        string typeOfList = Console.ReadLine();

        List<Song> filteredSongs = songs
            .Where(s => s.TypeList == typeOfList || typeOfList == "all")
            .ToList();

        foreach (Song item in filteredSongs)
        {
            Console.WriteLine(item.Name);
        }

    }
}

internal class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}