
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        List<double> firstList = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<double> secondList = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        mergingLists(firstList, secondList);
    }

    private static void mergingLists(List<double> firstList, List<double> secondList)
    {
        List<double> newList = new List<double>();
        int countFirst = 0;
        int countSecond = 0;

        if (firstList.Count < secondList.Count)
        {
            for (int i = 0; i < firstList.Count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    newList.Add(firstList[countFirst]);
                    countFirst++;
                }
                else
                {
                    newList.Add(secondList[countSecond]);
                    countSecond++;
                }

            }

            for (int i = firstList.Count; i < secondList.Count; i++)
            {
                newList.Add(secondList[i]);
            }

            countFirst = 0;
            countSecond = 0;
        }
        else if (firstList.Count > secondList.Count)
        {
            for (int i = 0; i < secondList.Count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    newList.Add(firstList[countFirst]);
                    countFirst++;
                }
                else
                {
                    newList.Add(secondList[countSecond]);
                    countSecond++;
                }

            }

            for (int i = secondList.Count; i < firstList.Count; i++)
            {
                newList.Add(firstList[i]);
            }

            countFirst = 0;
            countSecond = 0;
        }
        else
        {
            for (int i = 0; i < firstList.Count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    newList.Add(firstList[countFirst]);
                    countFirst++;
                }
                else
                {
                    newList.Add(secondList[countSecond]);
                    countSecond++;
                }

            }
            countFirst = 0;
            countSecond = 0;
        }
        Console.WriteLine(string.Join(" ", newList));
    }
}