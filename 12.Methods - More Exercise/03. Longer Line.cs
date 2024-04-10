using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);


    }

    private static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double resultXY1 = Math.Abs(x1) + Math.Abs(y1);
        double resultXY2 = Math.Abs(x2) + Math.Abs(y2);
        double resultXY3 = Math.Abs(x3) + Math.Abs(y3);
        double resultXY4 = Math.Abs(x4) + Math.Abs(y4);


        double firstTotalXY = resultXY1 + resultXY2;
        double secondTotalXY = resultXY3 + resultXY4;

        if (firstTotalXY >= secondTotalXY)
        {
            if (resultXY1 > resultXY2 && resultXY1 > 0)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
        else
        {
            if (resultXY3 > resultXY4 && resultXY3 > 0)
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
            else
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
        }
    }
}