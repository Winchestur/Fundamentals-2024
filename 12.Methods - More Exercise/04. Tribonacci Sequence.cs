using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        TribonacciSequence(n);
    }

    private static void TribonacciSequence(int n)
    {
        int count = 0;
        List<int> list = new List<int>();
        list.Add(1);
        List<int> result = new List<int>();
        int counter = 0;

        while (n - 1 > count)
        {
            for (int i = count; i < list.Count; i++)
            {
                if (i == 0)
                {
                    result.Add(list[i] + 0);
                }
                else if (i > 0)
                {
                    for (int j = i; j >= i - 2; j--)
                    {

                        result[0] += list[j];
                        if (i == counter)
                        {
                            break;
                        }

                        counter++;
                    }
                }
                counter = 0;
            }
            list.Add(result[0]);
            result[0] = 0;
            count++;
        }
        Console.WriteLine(string.Join(" ", list));
    }
}