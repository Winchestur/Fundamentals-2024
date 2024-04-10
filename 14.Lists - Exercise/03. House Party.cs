namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] guests = Console.ReadLine().Split();

                if (list.Contains(guests[0]) && guests[2] == "going!")
                {
                    Console.WriteLine($"{guests[0]} is already in the list!");
                }
                else if (guests.Contains("not"))
                {
                    if (list.Contains(guests[0]))
                    {
                        list.Remove(guests[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{guests[0]} is not in the list!");
                    }
                }
                else
                {
                    list.Add(guests[0]);
                }
            }

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}