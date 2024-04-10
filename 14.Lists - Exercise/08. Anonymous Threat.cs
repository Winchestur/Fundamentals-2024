using System.Diagnostics.Metrics;
using System.Numerics;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> commands = Console.ReadLine().Split().ToList();

        List<string> newList = new List<string>();




        while (commands[0] != "3:1")
        {
            operations(names, commands, newList);

            commands = Console.ReadLine().Split().ToList();
        }

        Console.WriteLine(string.Join(" ", names));
    }

    private static void operations(List<string> names, List<string> commands, List<string> newList)
    {
        string typeOfOperation = commands[0];


        switch (typeOfOperation)
        {
            case "merge":

                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                int count = 0;

                if (startIndex >= 0 && startIndex < names.Count - 1 && startIndex < endIndex && endIndex <= names.Count - 1)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (count < endIndex - startIndex)
                        {
                            names[startIndex] += names[i + 1];
                            names.RemoveAt(i + 1);
                            i--;
                        }
                        else if (count == endIndex - startIndex)
                        {
                            break;
                        }

                        count++;
                    }
                }
                else if (startIndex <= names.Count - 1 && endIndex >= names.Count)
                {
                    for (int i = startIndex; i < names.Count; i++)
                    {


                        if (i + 1 < names.Count)
                        {
                            names[startIndex] += names[i + 1];
                            names.RemoveAt(i + 1);
                            i--;
                        }
                        //else if (i + 1 >= names.Count)
                        //{
                        //    names[startIndex] += names[i];
                        //    break;
                        //}

                    }
                }

                break;
            case "divide":

                int index = int.Parse(commands[1]);
                int partition = int.Parse(commands[2]);
                int counter = 0;
                int indexer = -1;
                int countsToEnd = 0;
                int newCounter = 0;
                int timesToAppend = 1;

                newList.Clear();

                if (index >= 0 && index <= names.Count - 1)
                {
                    int result = names[index].Length / partition;

                    if (result > 0)
                    {
                        List<string> saveList = new List<string>();

                        foreach (char item in names[index])
                        {
                            if (countsToEnd < partition)
                            {
                                if (counter == 0 || result < 2)
                                {
                                    newList.Add(item.ToString());
                                    counter++;
                                    indexer++;
                                    countsToEnd++;
                                }
                                else if (counter == 1 && result > 1 && timesToAppend < result)
                                {
                                    newList[indexer] += item;
                                    timesToAppend++;
                                }

                                if (timesToAppend >= result)
                                {
                                    counter = 0;
                                    timesToAppend = 1;
                                }


                            }
                            else
                            {
                                newList[indexer] += item;
                            }
                        }

                        names.RemoveAt(index);
                        newList.Reverse();

                        for (int i = 0; i < newList.Count; i++)
                        {
                            names.Insert(index, newList[i]);
                        }
                    }
                }

                break;
        }
    }
}