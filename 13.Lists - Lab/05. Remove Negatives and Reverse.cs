internal class Program
{
    private static void Main(string[] args)
    {
        List<double> list = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<double> newList = new List<double>();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] >= 0)
            {
                newList.Add(list[i]);
            }
        }

        newList.Reverse();

        if (newList.Count > 0)
        {
            Console.WriteLine($"{string.Join(" ", newList)}");
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}