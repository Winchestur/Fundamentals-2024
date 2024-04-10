internal class Program
{
    private static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine());
        string Operator = Console.ReadLine();
        int numTwo = int.Parse(Console.ReadLine());

        result(numOne, Operator, numTwo);
    }

    private static void result(int numOne, string Operator, int numTwo)
    {

        int result = 0;

        if (Operator == "+")
        {
            result = numOne + numTwo;
        }
        else if (Operator == "-")
        {
            if (numOne > numTwo)
            {
                result = numOne - numTwo;
            }
            else
            {
                result = numTwo - numOne;
            }
        }
        else if (Operator == "*")
        {
            result = numTwo * numOne;
        }
        else if (Operator == "/")
        {
            if (numOne > numTwo)
            {
                result = numOne / numTwo;
            }
            else
            {
                result = numTwo / numOne;
            }
        }
        Console.WriteLine(result);
    }
}