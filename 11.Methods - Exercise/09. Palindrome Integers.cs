internal class Program
{
    private static void Main(string[] args)
    {
        string num = Console.ReadLine();

        palindromeIntegers(num);
    }

    private static void palindromeIntegers(string num)
    {
        int takeLastNum = 0;
        string newNum = "";
        int saveNum = 0;
        if (num != "END")
        {
            saveNum = int.Parse(num);
        }
        string text = num.ToString();
        while (num != "END")
        {

            while (int.Parse(num) > 0)
            {
                takeLastNum = int.Parse(num) % 10;
                int result = int.Parse(num) / 10;
                num = result.ToString();
                newNum += takeLastNum;
                result = 0;
            }

            if (int.Parse(newNum) == saveNum)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            num = Console.ReadLine();

            if (num != "END")
            {
                saveNum = int.Parse(num);
            }
            newNum = "";
        }
    }
}