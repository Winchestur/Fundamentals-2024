internal class Program
{
    private static void Main(string[] args)
    {
        double Base = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        double result = mathPower(Base, power);
        Console.WriteLine(result);
    }

    private static double mathPower(double Base, double power)
    {
        double result = Math.Pow(Base, power);

        return result;
    }
}