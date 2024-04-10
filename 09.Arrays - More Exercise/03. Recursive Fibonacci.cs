using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();

        list.Add(1);
        list.Add(1);

        int counter = 0;

        while (counter < n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j <= i + 1; j++)
                {
                    list.Add(list[i] + list[j]);
                }
            }

            counter++;
        }

        int takeLastNum = 0;
        for (int i = list.Count - 1; i >= list.Count - 1; i--)
        {
            takeLastNum = list[i];
        }

        Console.WriteLine(takeLastNum);
    }
}