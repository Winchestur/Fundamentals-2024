internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();
        double numOne = double.Parse(Console.ReadLine());
        double numTwo = double.Parse(Console.ReadLine());


        if (type == "add")
        {
            add(numOne, numTwo);
        }
        else if (type == "subtract")
        {
            subtract(numOne, numTwo);
        }
        else if (type == "divide")
        {
            divide(numOne, numTwo);
        }
        else if (type == "multiply")
        {
            multiply(numOne, numTwo);
        }
    }

    private static void multiply(double numOne, double numTwo)
    {
        double result = numOne * numTwo;
        Console.WriteLine(result);
    }

    private static void divide(double numOne, double numTwo)
    {
        double result = 0;

        if (numOne >= numTwo)
        {
            result = numOne / numTwo;
        }
        else if (numTwo > numOne)
        {
            result = numTwo / numOne;
        }

        Console.WriteLine(result);
    }

    private static void subtract(double numOne, double numTwo)
    {
        double result = 0;

        if (numOne >= numTwo)
        {
            result = numOne - numTwo;
        }
        else if (numTwo > numOne)
        {
            result = numTwo - numOne;
        }

        Console.WriteLine(result);
    }

    private static void add(double numOne, double numTwo)
    {
        double result = numOne + numTwo;
        Console.WriteLine(result);
    }
}