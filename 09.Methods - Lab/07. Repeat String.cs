internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string newText = repeater(text, n);

        Console.WriteLine(newText);
    }

    private static string repeater(string text, int n)
    {
        string newText = "";

        for (int i = 0; i < n; i++)
        {
            newText += text;
        }
        return newText;
    }
}