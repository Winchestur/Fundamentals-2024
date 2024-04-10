internal class Program
{
    private static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        double sumFirst = 1;
        double sumSecond = 1;
        double result = 0;

        for (int i = 1; i <= firstNum; i++)
        {
            sumFirst *= i;
        }

        for (int i = 1; i <= secondNum; i++)
        {
            sumSecond *= i;
        }

        result = sumFirst / sumSecond;
        Console.WriteLine($"{result:F2}");
    }
}