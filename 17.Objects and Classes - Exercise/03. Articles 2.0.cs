using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }
    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int counts = int.Parse(Console.ReadLine());

        List<Article> newArticles = new List<Article>();

        for (int i = 0; i < counts; i++)
        {
            List<string> texts = Console.ReadLine().Split(", ").ToList();
            Article article = new Article(texts[0], texts[1], texts[2]);

            newArticles.Add(article);
        }

        foreach (Article item in newArticles)
        {
            Console.WriteLine(item);
        }
    }
}