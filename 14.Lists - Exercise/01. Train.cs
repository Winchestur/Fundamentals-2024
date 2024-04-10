internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        passengers(list, maxCapacity);
    }

    private static void passengers(List<int> list, int maxCapacity)
    {
        string[] command = Console.ReadLine().Split().ToArray();

        while (command[0] != "end")
        {
            if (command[0] == "Add")
            {
                list.Add(int.Parse(command[1]));
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i] + int.Parse(command[0]) <= maxCapacity)
                    {
                        list[i] += int.Parse(command[0]);
                        break;
                    }

                }
            }
            command = Console.ReadLine().Split().ToArray();
        }
        Console.WriteLine($"{string.Join(" ", list)}");
    }
}