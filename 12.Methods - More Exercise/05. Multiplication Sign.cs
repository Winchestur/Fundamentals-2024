using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum * secondNum * thirdNum == 0)
        {
            Console.WriteLine("zero");
        }
        if (firstNum * secondNum * thirdNum < 0)
        {
            Console.WriteLine("negative");
        }
        if (firstNum * secondNum * thirdNum > 0)
        {
            Console.WriteLine("positive");
        }
    }
}