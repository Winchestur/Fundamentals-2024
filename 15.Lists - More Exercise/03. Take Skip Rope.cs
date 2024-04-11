internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();

        List<string> numbers = new List<string>();
        List<char> chars = text.ToList();
        List<int> TakeList = new List<int>();
        List<int> SkipList = new List<int>();



        for (int i = 0; i < chars.Count; i++)
        {
            if (Char.IsDigit(chars[i]))
            {
                numbers.Add(chars[i].ToString());
                chars.RemoveAt(i);
                i--;
            }
        }

        if (numbers.Count % 2 == 0)
        {
            //separate numbers in TakeList or SkipList by cheking even or odd index
            for (int i = 0; i < numbers.Count; i++)
            {
                int takeNumber = int.Parse(numbers[i]);

                if (i % 2 == 0)
                {
                    TakeList.Add(takeNumber);
                }
                else
                {
                    SkipList.Add(takeNumber);
                }
            }

            string result = "";
            int countTakes = 1;
            int currentIndex = -1;

            for (int i = 0; i < chars.Count;)
            {
                currentIndex++;

                if (currentIndex == TakeList.Count)
                {
                    break;
                }

                while (countTakes <= TakeList[currentIndex])
                {
                    if (i >= chars.Count)
                    {
                        break;
                    }

                    countTakes++;
                    result += chars[i];
                    i++;
                }

                countTakes = 1;
                i += SkipList[currentIndex];
            }


            Console.WriteLine(result);
        }
    }
}