internal class Program
{
    private static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        int sum = 0;
        int substract = 0;

        sum = sumNum(numOne, numTwo);
        substract = substractNums(sum, numThree);

        Console.WriteLine(substract);
    }

    private static int substractNums(int sum, int numThree)
    {
        int result = sum - numThree;
        return result;
    }

    private static int sumNum(int numOne, int numTwo)
    {
        int result = numOne + numTwo;

        return result;
    }
}