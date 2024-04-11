namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListOfNums = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            List<int> secondListOfNums = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>();
            List<int> result = new List<int>();

            secondListOfNums.Reverse();

            if (firstListOfNums.Count > secondListOfNums.Count)
            {
                int countIndex = 0;
                for (int i = 0; i < secondListOfNums.Count * 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        newList.Add(firstListOfNums[countIndex]);
                    }
                    else
                    {
                        newList.Add(secondListOfNums[countIndex]);
                        countIndex++;
                    }
                }

                int[] BeginEnd = new int[2];
                //take last 2 nums of longer list

                int count = 0;

                for (int i = secondListOfNums.Count; i < firstListOfNums.Count; i++)
                {
                    BeginEnd[count] = firstListOfNums[i];
                    count++;
                }

                if (BeginEnd[0] > BeginEnd[1])
                {
                    for (int i = 0; i < newList.Count; i++)
                    {
                        if (BeginEnd[1] < newList[i] && newList[i] < BeginEnd[0])
                            result.Add(newList[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < newList.Count; i++)
                    {
                        if (BeginEnd[0] < newList[i] && newList[i] < BeginEnd[1])
                            result.Add(newList[i]);
                    }
                }
            }
            else
            {
                int countIndex = 0;
                for (int i = 0; i < firstListOfNums.Count * 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        newList.Add(firstListOfNums[countIndex]);
                    }
                    else
                    {
                        newList.Add(secondListOfNums[countIndex]);
                        countIndex++;
                    }
                }

                int[] BeginEnd = new int[2];
                //take last 2 nums of longer list
                int count = 0;

                for (int i = firstListOfNums.Count; i < secondListOfNums.Count; i++)
                {
                    BeginEnd[count] = secondListOfNums[i];
                    count++;
                }

                if (BeginEnd[0] > BeginEnd[1])
                {
                    for (int i = 0; i < newList.Count; i++)
                    {
                        if (BeginEnd[1] < newList[i] && newList[i] < BeginEnd[0])
                            result.Add(newList[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < newList.Count; i++)
                    {
                        if (BeginEnd[0] < newList[i] && newList[i] < BeginEnd[1])
                            result.Add(newList[i]);
                    }
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
