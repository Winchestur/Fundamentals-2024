

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "End")
            {
                operations(list, commands);

                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", list));
        }

        private static void operations(List<int> list, string[] commands)
        {
            if (commands[0] == "Add")
            {
                int number = int.Parse(commands[1]);

                add(list, number);

            }
            else if (commands[0] == "Insert")
            {
                int number = int.Parse(commands[1]);
                int index = int.Parse(commands[2]);

                if (index < 0 || index > list.Count - 1)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    insert(list, number, index);
                }
            }
            else if (commands[0] == "Remove")
            {
                int index = int.Parse(commands[1]);

                if (index < 0 || index > list.Count - 1)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    remove(list, index);
                }
            }
            else if (commands[0] == "Shift" && commands[1] == "left")
            {
                int count = int.Parse(commands[2]);
                shiftLeft(list, count);
            }
            else if (commands[0] == "Shift" && commands[1] == "right")
            {
                int count = int.Parse(commands[2]);
                shiftRight(list, count);
            }
        }

        private static void shiftRight(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int takeLastNum = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, takeLastNum);
            }
        }

        private static void shiftLeft(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int takeFirstNum = list[0];
                list.RemoveAt(0);
                list.Add(takeFirstNum);
            }
        }

        private static void insert(List<int> list, int number, int index)
        {
            list.Insert(index, number);
        }

        private static void remove(List<int> list, int index)
        {
            list.RemoveAt(index);
        }

        private static void add(List<int> list, int number)
        {
            list.Add(number);
        }
    }
}
