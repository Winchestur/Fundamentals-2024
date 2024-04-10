internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();

        volewsChecker(text);
    }
    private static void volewsChecker(string text)
    {
        char[] chars = { 'a', 'e', 'i', 'o', 'u' };
        int count = 0;

        foreach (char item in text.ToLower())
        {
            if (chars.Contains(item))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}