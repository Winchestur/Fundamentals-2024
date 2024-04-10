internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        SquareOfNums(n);
    }

    private static void SquareOfNums(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }
}