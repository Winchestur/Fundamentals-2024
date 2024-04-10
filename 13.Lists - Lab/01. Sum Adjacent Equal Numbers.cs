using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<double> list = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        sumAdjacentEqualNumbers(list);
    }

    private static void sumAdjacentEqualNumbers(List<double> list)
    {
        int countIfChange = 1;
        List<double> list2 = new List<double>();

        while (countIfChange != 0)
        {
            countIfChange = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] == list[j - 1])
                    {
                        list2.Add(list[j] + list[j - 1]);
                        list.RemoveAt(j);
                        list.RemoveAt(j - 1);
                        list.Insert(j - 1, list2[0]);
                        list2.RemoveAt(0);
                        countIfChange++;
                        break;
                    }
                }
                if (countIfChange > 0)
                {
                    break;
                }
            }

        }
        Console.WriteLine($"{string.Join(" ", list)}");
    }
}