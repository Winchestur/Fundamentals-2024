namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ").ToList();

            //list = list.SelectMany(item => item.Split(",", ' ' ,StringSplitOptions.RemoveEmptyEntries)).ToList();

            List<string> command = Console.ReadLine()
                .Split(":").ToList();

            while (command[0] != "course start")
            {
                operations(list, command);

                command = Console.ReadLine().Split(":").ToList();
            }

            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                count++;
                Console.WriteLine($"{count}.{list[i]}");
            }
        }

        private static void operations(List<string> list, List<string> command)
        {

            if (command[0] == "Add")
            {
                string title = command[1];

                if (list.Contains(title))
                {

                }
                else
                {
                    list.Add(title);
                }
            }
            else if (command[0] == "Remove")
            {
                string title = command[1];

                if (list.Contains(title))
                {
                    if (list.Contains(title + "-Exercise"))
                    {
                        list.Remove(title + "-Exercise");
                    }

                    list.Remove(title);

                }
            }
            else if (command[0] == "Insert")
            {
                string title = command[1];
                int index = int.Parse(command[2]);

                if (list.Contains(title))
                {

                }
                else
                {
                    list.Insert(index, title);
                }
            }
            else if (command[0] == "Exercise")
            {
                string title = command[1];

                if (list.Contains(title))
                {
                    if (list.Contains(title + "-Exercise"))
                    {

                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == title)
                            {
                                list.Insert(i + 1, title + "-Exercise");
                            }
                        }
                    }
                }
                else
                {
                    list.Add(title);
                    list.Add(title + "-Exercise");
                }
            }
            else if (command[0] == "Swap")
            {
                string FirstTitle = command[1];
                string SecondTitle = command[2];

                if (list.Contains(FirstTitle) && list.Contains(SecondTitle))
                {
                    int indexFirst = 0;
                    int indexSecond = 0;

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == FirstTitle)
                        {
                            indexFirst = i;
                        }
                        else if (list[i] == SecondTitle)
                        {
                            indexSecond = i;
                        }
                    }

                    list.RemoveAt(indexSecond);
                    list.Insert(indexSecond, FirstTitle);
                    list.RemoveAt(indexFirst);
                    list.Insert(indexFirst, SecondTitle);

                    if (list.Contains(FirstTitle + "-Exercise"))
                    {
                        list.Remove(FirstTitle + "-Exercise");
                        list.Insert(indexSecond + 1, FirstTitle + "-Exercise");
                    }
                    else if (list.Contains(SecondTitle + "-Exercise"))
                    {
                        list.Remove(SecondTitle + "-Exercise");
                        list.Insert(indexFirst + 1, SecondTitle + "-Exercise");
                    }

                }
            }

        }
    }
}
