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

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }
    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
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
        List<string> texts = Console.ReadLine().Split(", ").ToList();
        int counts = int.Parse(Console.ReadLine());

        Article article = new Article(texts[0], texts[1], texts[2]);

        for (int i = 0; i < counts; i++)
        {
            List<string> commands = Console.ReadLine().Split(": ").ToList();

            Operations(commands, texts, article);
        }

        Console.WriteLine(article);
    }

    private static void Operations(List<string> commands, List<string> texts, Article article)
    {

        switch (commands[0])
        {
            case "Edit":

                article.Edit(commands[1]);

                break;
            case "ChangeAuthor":

                article.ChangeAuthor(commands[1]);

                break;
            case "Rename":

                article.Rename(commands[1]);
                break;
        }
    }
}