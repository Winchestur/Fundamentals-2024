using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> newList = new List<int>();

        List<int> savedNumber = new List<int>();

        int endNumber = 0;
        int currentNum = 0;
        int lastIndex = 0;
        int savedIndex = 0;
        int countLength = 0;
        int savedLength = 0;
        int previousNum = int.MinValue;

        for (int i = 0; i < numbers.Count; i++)
        {
            endNumber = numbers[i];
            lastIndex = i;

            for (int j = 0; j <= i; j++)
            {
                currentNum = numbers[j];

                if (currentNum < endNumber && currentNum > previousNum || j == i)
                {
                    newList.Add(numbers[j]);
                    countLength++;
                    previousNum = currentNum;
                }
            }

            if (countLength > savedLength)
            {
                savedNumber.Clear();
                savedIndex = lastIndex;
                savedLength = countLength;
                savedNumber.AddRange(newList);
            }
            else if (countLength == previousNum && lastIndex < savedIndex)
            {
                savedNumber.Clear();
                savedIndex = lastIndex;
                savedLength = countLength;
                savedNumber.AddRange(newList);
            }

            previousNum = int.MinValue;
            countLength = 0;
            newList.Clear();
        }

        Console.WriteLine(string.Join(" ", savedNumber));
    }
}