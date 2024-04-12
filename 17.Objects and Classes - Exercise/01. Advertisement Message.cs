using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class NewsPaper
{
    public string Phrases { get; set; }
    public string Events { get; set; }
    public string Authors { get; set; }
    public string Cities { get; set; }

    public NewsPaper(string phrases, string events, string authors, string cities)
    {
        Phrases = phrases;
        Events = events;
        Authors = authors;
        Cities = cities;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        Random random = new Random();

        List<NewsPaper> news = new List<NewsPaper>();

        string phrase = "";
        string events = "";
        string authors = "";
        string cities = "";

        for (int i = 0; i < counter; i++)
        {
            phrase = Phrases(random);
            events = Events(random);
            authors = Authors(random);
            cities = Cities(random);

            NewsPaper newsPaper = new NewsPaper(phrase, events, authors, cities);

            news.Add(newsPaper);
        }

        foreach (NewsPaper item in news)
        {
            Console.WriteLine($"{item.Phrases} {item.Events} {item.Authors} – {item.Cities}.");
        }

    }

    private static string Cities(Random random)
    {
        string[] cities =
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        int index = random.Next(0, cities.Length);

        return cities[index];
    }

    private static string Authors(Random random)
    {
        string[] authors =
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        int index = random.Next(0, authors.Length);

        return authors[index];
    }

    private static string Events(Random random)
    {
        string[] events =
        {
            "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"
        };

        int index = random.Next(0, events.Length);

        return events[index];
    }

    private static string Phrases(Random random)
    {
        string[] phrase =
        {
            "Excellent product.", "Such a great product.",
            "I always use that product.", "Best product of its category.",
            "Exceptional product.", "I can't live without this product."
        };

        int index = random.Next(0, phrase.Length);

        return phrase[index];
    }
}