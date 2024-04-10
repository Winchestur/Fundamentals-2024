internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        listManipulation(list);
    }

    private static void listManipulation(List<int> list)
    {
        int[] count = new int[1];

        string[] command = Console.ReadLine().Split();

        while (command[0] != "end")
        {

            if (command[0] == "Add")
            {
                add(list, command, count);
            }
            else if (command[0] == "Remove")
            {
                remove(list, command, count);
            }
            else if (command[0] == "RemoveAt")
            {
                removeAt(list, command, count);
            }
            else if (command[0] == "Insert")
            {
                insert(list, command, count);
            }

            else if (command[0] == "Contains")
            {
                contains(list, command);
            }
            else if (command[0] == "PrintEven")
            {
                printEven(list, command);
            }
            else if (command[0] == "PrintOdd")
            {
                printOdd(list, command);
            }
            else if (command[0] == "GetSum")
            {
                getSum(list, command);
            }
            else if (command[0] == "Filter")
            {
                filter(list, command);
            }

            command = Console.ReadLine().Split();
        }

        if (count[0] > 0)
        {
            Console.WriteLine($"{string.Join(" ", list)}");
        }
    }

    private static void insert(List<int> list, string[] command, int[] count)
    {
        int number = int.Parse(command[1]);
        int index = int.Parse(command[2]);

        list.Insert(index, number);
        count[0] = 1;
    }

    private static void removeAt(List<int> list, string[] command, int[] count)
    {
        int index = int.Parse(command[1]);

        list.RemoveAt(index);
        count[0] = 1;
    }

    private static void remove(List<int> list, string[] command, int[] count)
    {
        int number = int.Parse(command[1]);

        list.Remove(number);
        count[0] = 1;
    }

    private static void add(List<int> list, string[] command, int[] count)
    {
        int number = int.Parse(command[1]);

        list.Add(number);
        count[0] = 1;
    }
    private static void filter(List<int> list, string[] command)
    {
        string condition = command[1];
        int number = int.Parse(command[2]);

        for (int i = 0; i < list.Count; i++)
        {
            Operator(list, number, condition, i);
        }
        Console.WriteLine();
    }

    private static void Operator(List<int> list, int number, string condition, int i)
    {
        if (condition == ">")
        {
            if (list[i] > number)
            {
                Console.Write($"{list[i]} ");
            }
        }
        else if (condition == "<")
        {
            if (list[i] < number)
            {
                Console.Write($"{list[i]} ");
            }
        }
        else if (condition == ">=")
        {
            if (list[i] >= number)
            {
                if (list[i] == number)
                {
                    Console.Write($"{list[i]} ");
                }
                else if (list[i] > number)
                {
                    Console.Write($"{list[i]} ");
                }
            }
        }
        else if (condition == "<=")
        {
            if (list[i] <= number)
            {
                if (list[i] == number)
                {
                    Console.Write($"{list[i]} ");
                }
                else if (list[i] < number)
                {
                    Console.Write($"{list[i]} ");
                }
            }
        }
    }

    private static void getSum(List<int> list, string[] command)
    {
        int sum = 0;

        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        Console.WriteLine(sum);
    }

    private static void printOdd(List<int> list, string[] command)
    {
        List<int> newList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 == 1)
            {
                newList.Add(list[i]);
            }
        }
        Console.WriteLine(string.Join(" ", newList));
    }

    private static void printEven(List<int> list, string[] command)
    {
        List<int> newList = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 == 0)
            {
                newList.Add(list[i]);
            }
        }
        Console.WriteLine(string.Join(" ", newList));
    }

    private static void contains(List<int> list, string[] command)
    {
        int number = int.Parse(command[1]);

        if (list.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
}