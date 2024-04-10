internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        printingTriangle(n);
    }

    private static void printingTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }

        int counter = 1;

        for (int i = n - 1; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write($"{counter} ");
                counter++;
            }
            Console.WriteLine();
            counter = 1;
        }

    }
}