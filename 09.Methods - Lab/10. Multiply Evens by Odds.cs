internal class Program
{
    private static void Main(string[] args)
    {
        int num = Math.Abs(int.Parse(Console.ReadLine()));


        GetMultipleOfEvenAndOdds(num);

    }

    private static void GetMultipleOfEvenAndOdds(int num)
    {
        int sumEven = 0;
        int sumOdd = 0;
        int result = 0;

        while (num > 0)
        {

            int takeLastNum = num % 10;
            num /= 10;

            sumEven += GetSumOfEvenDigits(takeLastNum, result);
            sumOdd += GetSumOfOddDigits(takeLastNum, result);
        }

        int totalResult = sumEven * sumOdd;
        Console.WriteLine(totalResult);
    }

    private static int GetSumOfOddDigits(int takeLastNum, int result)
    {

        if (takeLastNum % 2 == 0)
        {
            result = takeLastNum;
        }
        return result;
    }

    private static int GetSumOfEvenDigits(int takeLast, int result)
    {

        if (takeLast % 2 == 1)
        {
            result = takeLast;
        }
        return result;
    }
}