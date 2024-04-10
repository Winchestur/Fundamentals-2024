internal class Program
{
    private static void Main(string[] args)
    {
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());

        getMin(numOne, numTwo, numThree);
    }

    private static void getMin(int numOne, int numTwo, int numThree)
    {
        int result = Math.Min(numOne, numTwo);
        int totalResult = Math.Min(result, numThree);

        Console.WriteLine(totalResult);
    }
}