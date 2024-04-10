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
        string[] command = Console.ReadLine().Split();

        while (command[0] != "end")
        {
            if (command[0] == "Add")
            {
                add(list, command);
            }
            else if (command[0] == "Remove")
            {
                remove(list, command);
            }
            else if (command[0] == "RemoveAt")
            {
                removeAt(list, command);
            }
            else if (command[0] == "Insert")
            {
                insert(list, command);
            }

            command = Console.ReadLine().Split();
        }
        Console.WriteLine($"{string.Join(" ", list)}");
    }

    private static void insert(List<int> list, string[] command)
    {
        int number = int.Parse(command[1]);
        int index = int.Parse(command[2]);

        list.Insert(index, number);
    }

    private static void removeAt(List<int> list, string[] command)
    {
        int index = int.Parse(command[1]);

        list.RemoveAt(index);
    }

    private static void remove(List<int> list, string[] command)
    {
        int number = int.Parse(command[1]);

        list.Remove(number);
    }

    private static void add(List<int> list, string[] command)
    {
        int number = int.Parse(command[1]);

        list.Add(number);
    }
}