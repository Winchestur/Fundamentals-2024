using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string text = Console.ReadLine();
            list.Add(text);
        }

        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            count++;
            Console.WriteLine($"{count}.{list[i]}");
        }
    }
}