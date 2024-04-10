using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<double> list = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        gaussTrick(list);
    }

    private static void gaussTrick(List<double> list)
    {
        List<double> newList = new List<double>();

        for (int i = 0; i < list.Count; i++)
        {
            if (i == list.Count - 1 - i)
            {
                newList.Add(list[i]);
                break;
            }
            if (list.Count % 2 == 0 && list.Count / 2 == i)
            {
                break;
            }
            else
            {
                newList.Add(list[i] + list[list.Count - 1 - i]);
            }
        }

        Console.WriteLine(string.Join(" ", newList));
    }
}