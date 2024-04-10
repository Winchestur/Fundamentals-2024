using System.Net.WebSockets;

internal class Program
{
    private static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        closestToZero(x1, y1, x2, y2);
    }

    private static void closestToZero(double x1, double y1, double x2, double y2)
    {
        double resultFirstXY = Math.Abs(x1) + Math.Abs(y1);
        double resultSecondXY = Math.Abs(x2) + Math.Abs(y2);

        if (resultFirstXY >= 0 && resultFirstXY <= resultSecondXY)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else if (resultFirstXY <= 0 && resultFirstXY >= resultSecondXY)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}