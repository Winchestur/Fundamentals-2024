internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        TopNumber(n);
    }

    private static void TopNumber(int n)
    {
        int currentNum = 0;
        int takeLast = 0;
        int sumNum = 0;
        int countOdd = 0;
        for (int i = 1; i <= n; i++)
        {
            currentNum = i;

            while (currentNum > 0)
            {
                takeLast = currentNum % 10;
                currentNum /= 10;
                sumNum += takeLast;

                if (takeLast % 2 == 1)
                {
                    countOdd++;
                }
            }
            if (sumNum % 8 == 0 && countOdd > 0)
            {
                Console.WriteLine(i);
            }
            sumNum = 0;
            countOdd = 0;
        }
    }
}