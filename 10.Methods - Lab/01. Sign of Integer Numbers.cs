internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        positive(number);
        negative(number);
        zero(number);
    }

    private static void zero(int num)
    {
        if (num == 0)
        {
            Console.WriteLine($"The number {num} is zero.");
        }
    }

    private static void negative(int num)
    {
        if (num < 0)
        {
            Console.WriteLine($"The number {num} is negative.");
        }
    }

    private static void positive(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"The number {num} is positive.");
        }
    }
}