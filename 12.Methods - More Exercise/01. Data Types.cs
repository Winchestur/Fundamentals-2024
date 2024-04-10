internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();

        if (text == "int")
        {
            integer();
        }
        else if (text == "real")
        {
            realNum();
        }
        else if (text == "string")
        {
            Text();
        }
    }

    private static void Text()
    {
        string text = Console.ReadLine();

        Console.WriteLine($"${text}$");
    }

    private static void realNum()
    {
        double num = double.Parse(Console.ReadLine());

        double result = num * 1.5;

        Console.WriteLine($"{result:F2}");
    }

    private static void integer()
    {
        int num = int.Parse(Console.ReadLine());

        int result = num * 2;

        Console.WriteLine(result);
    }
}