internal class Program
{
    private static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int result = area(firstNum, secondNum);

        Console.WriteLine(result);
    }

    private static int area(int firstNum, int secondNum)
    {

        return firstNum * secondNum;
    }
}