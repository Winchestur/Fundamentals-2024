internal class Program
{
    private static void Main(string[] args)
    {

        string text = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        price(text, quantity);

    }

    public static void price(string text, int quantity)
    {
        double coffee = 1.50;
        double water = 1.00;
        double coke = 1.40;
        double snacks = 2.00;

        double result = 0.0;

        if (text == "coffee")
        {
            result = coffee * quantity;
        }
        else if (text == "water")
        {
            result = water * quantity;
        }
        else if (text == "coke")
        {
            result = coke * quantity;
        }
        else if (text == "snacks")
        {
            result = snacks * quantity;
        }

        Console.WriteLine($"{result:F2}");
    }
}