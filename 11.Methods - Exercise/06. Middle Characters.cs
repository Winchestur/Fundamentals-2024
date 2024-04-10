internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();

        takeMiddleLetters(text);
    }

    private static void takeMiddleLetters(string? text)
    {
        int count = 0;
        int times = 0;

        foreach (char item in text)
        {
            count++;
            if (text.Length % 2 == 0 && (text.Length + 1) / 2 <= count && times < 2)
            {
                times++;
                Console.Write(item);
            }
            else if (text.Length % 2 == 1 && (text.Length + 1) / 2 == count && times < 1)
            {
                times++;
                Console.Write(item);
            }
        }
    }
}