namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            int[] sumOfNums = new int[numbers.Count];


            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] > 0)
                {

                    int currentDigit = numbers[i] % 10;
                    numbers[i] /= 10;
                    sumOfNums[i] += currentDigit;
                }
            }

            List<string> newText = new List<string>();


            foreach (char item in text)
            {
                newText.Add(item.ToString());
            }

            for (int i = 0; i < sumOfNums.Length; i++)
            {
                if (sumOfNums[i] > newText.Count - 1)
                {
                    int result = sumOfNums[i] - newText.Count;

                    for (int k = 0; k < newText.Count; k++)
                    {
                        if (result == k)
                        {
                            Console.Write(newText[k]);
                            newText.RemoveAt(k);
                            break;
                        }
                    }
                }
                else if (sumOfNums[i] >= 0 && sumOfNums[i] < newText.Count)
                {
                    for (int j = 0; j < newText.Count; j++)
                    {
                        if (sumOfNums[i] == j)
                        {
                            Console.Write(newText[j]);
                            newText.RemoveAt(j);
                            break;
                        }
                    }
                }
            }

        }
    }
}