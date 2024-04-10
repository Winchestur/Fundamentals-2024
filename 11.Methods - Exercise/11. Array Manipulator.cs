using System.Numerics;
using System.Security.Authentication;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        List<string> commands = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<int> newList = new List<int>();

        while (commands[0] != "end")
        {
            if (commands[0] == "exchange")
            {
                exchange(list, commands, newList);
            }
            else if (commands[0] == "max")
            {
                maxEvenOdd(list, commands, newList);
            }
            else if (commands[0] == "min")
            {
                minEvenOdd(list, commands, newList);
            }
            else if (commands[0] == "first")
            {
                firstEvenOdd(list, commands, newList);
            }
            else if (commands[0] == "last")
            {
                lastEvenOdd(list, commands, newList);
            }
            commands = Console.ReadLine().Split().ToList();
        }
        Console.WriteLine($"[{string.Join(", ", list)}]");
    }

    private static void lastEvenOdd(List<int> list, List<string> commands, List<int> newList)
    {

        int count = 0;
        int counter = int.Parse(commands[1]);
        List<int> nums = new List<int>();

        if (counter >= 0 && counter <= list.Count && commands.Count > 2)
        {
            if (commands[2] == "even")
            {
                list.Reverse();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && count < counter)
                    {
                        count++;
                        nums.Add(list[i]);
                    }
                }
                list.Reverse();
                nums.Reverse();
                count = 0;
                Console.Write($"[{string.Join(", ", nums)}]");
                Console.WriteLine();
            }
            else if (commands[2] == "odd")
            {
                list.Reverse();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 1 && count < counter)
                    {
                        count++;
                        nums.Add(list[i]);
                    }
                }
                list.Reverse();
                nums.Reverse();
                count = 0;
                Console.Write($"[{string.Join(", ", nums)}]");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid count");
        }
    }

    private static void firstEvenOdd(List<int> list, List<string> commands, List<int> newList)
    {

        int count = 0;
        int counter = int.Parse(commands[1]);
        List<int> nums = new List<int>();

        if (counter >= 0 && counter <= list.Count && commands.Count > 2)
        {
            if (commands[2] == "even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0 && count < counter)
                    {
                        count++;
                        nums.Add(list[i]);
                    }
                }
                count = 0;
                Console.Write($"[{string.Join(", ", nums)}]");
                Console.WriteLine();
            }
            else if (commands[2] == "odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 1 && count < counter)
                    {
                        count++;
                        nums.Add((int)list[i]);
                    }
                }
                count = 0;
                Console.Write($"[{string.Join(", ", nums)}]");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid count");
        }
    }

    private static void minEvenOdd(List<int> list, List<string> commands, List<int> newList)
    {
        int currentNum = 0;
        int saveNum = int.MaxValue;
        int currentIndex = 0;
        int savedIndex = 0;
        int count = 0;

        if (commands[1] == "even")
        {
            for (int i = 0; i < list.Count; i++)
            {
                currentNum = list[i];
                currentIndex = i;
                if (currentNum % 2 == 0 && currentNum <= saveNum)
                {
                    saveNum = currentNum;
                    savedIndex = currentIndex;
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(savedIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        else if (commands[1] == "odd")
        {
            for (int i = 0; i < list.Count; i++)
            {
                currentNum = list[i];
                currentIndex = i;
                if (currentNum % 2 == 1 && currentNum <= saveNum)
                {
                    saveNum = currentNum;
                    savedIndex = currentIndex;
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(savedIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        count = 0;
        savedIndex = 0;
        saveNum = 0;
    }

    private static void maxEvenOdd(List<int> list, List<string> commands, List<int> newList)
    {
        int currentNum = 0;
        int saveNum = 0;
        int currentIndex = 0;
        int savedIndex = 0;
        int count = 0;

        if (commands[1] == "even")
        {
            for (int i = 0; i < list.Count; i++)
            {
                currentNum = list[i];
                currentIndex = i;
                if (currentNum % 2 == 0 && currentNum >= saveNum)
                {
                    saveNum = currentNum;
                    savedIndex = currentIndex;
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(savedIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        else if (commands[1] == "odd")
        {
            for (int i = 0; i < list.Count; i++)
            {
                currentNum = list[i];
                currentIndex = i;
                if (currentNum % 2 == 1 && currentNum >= saveNum)
                {
                    saveNum = currentNum;
                    savedIndex = currentIndex;
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine(savedIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        count = 0;
        savedIndex = 0;
        saveNum = 0;
    }

    private static void exchange(List<int> list, List<string> commands, List<int> newList)
    {
        int rangeRemover = int.Parse(commands[1]) + 1;
        int index = int.Parse(commands[1]);

        if (index >= 0 && index < list.Count)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i > int.Parse(commands[1]))
                {
                    newList.Add(list[i]);
                }
            }
            list.RemoveRange(rangeRemover, list.Count - rangeRemover);
            newList.AddRange(list);
            list.RemoveRange(0, list.Count);
            list.AddRange(newList);
            newList.RemoveRange(0, newList.Count);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
}