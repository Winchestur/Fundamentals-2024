internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string[] commands = Console.ReadLine().Split().ToArray();

        while (commands[0] != "end")
        {
            if (commands[0] == "Delete")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list.Remove(int.Parse(commands[1]));
                }
            }
            else if (commands[0] == "Insert")
            {
                list.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
            }

            commands = Console.ReadLine().Split().ToArray();
        }
        Console.WriteLine($"{string.Join(" ", list)}");
    }
}