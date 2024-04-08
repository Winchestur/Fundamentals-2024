using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {

        byte counter = byte.Parse(Console.ReadLine());
        string texts = Console.ReadLine();


        int count = 0;
        int savedCount = 1;
        int currentIndex = 0;
        int savedIndex = int.MaxValue;
        int currentInput = 0;
        int savedInput = 0;
        int sum = 0;
        int saveSum = 0;

        string[] numbers = new string[0];

        if (counter > 0)
        {
            numbers = texts.Split("!", StringSplitOptions.RemoveEmptyEntries);
        }

        int[] newArr = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            newArr[i] = int.Parse(numbers[i]);
        }


        if (numbers.Length == counter && counter > 1 && counter <= 100)
        {

            while (texts != "Clone them!")
            {
                currentInput++;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (int.Parse(numbers[i]) >= 0 && int.Parse(numbers[i]) <= 100)
                    {
                        currentIndex = i;
                        count++;

                        for (int j = i + 1; j < numbers.Length; j++)
                        {

                            if (numbers[i] == numbers[j])
                            {
                                count++;
                            }

                            else
                            {
                                break;
                            }
                        }

                        if (count > savedCount)
                        {
                            for (int k = 0; k < numbers.Length; k++)
                            {
                                sum += int.Parse(numbers[k]);
                            }

                            saveSum = sum;
                            savedIndex = currentIndex;
                            savedCount = count;
                            savedInput = currentInput;

                            for (int l = 0; l < numbers.Length; l++)
                            {
                                newArr[l] = int.Parse(numbers[l]);
                            }
                        }
                        else if (count == savedCount && currentIndex < savedIndex)
                        {
                            for (int k = 0; k < numbers.Length; k++)
                            {
                                sum += int.Parse(numbers[k]);
                            }

                            saveSum = sum;
                            savedIndex = currentIndex;
                            savedCount = count;
                            savedInput = currentInput;

                            for (int l = 0; l < numbers.Length; l++)
                            {
                                newArr[l] = int.Parse(numbers[l]);
                            }
                        }
                        else if (count == savedCount && currentIndex == savedIndex)
                        {
                            for (int k = 0; k < numbers.Length; k++)
                            {
                                sum += int.Parse(numbers[k]);
                            }

                            if (sum > saveSum)
                            {
                                saveSum = sum;
                                savedIndex = currentIndex;
                                savedCount = count;
                                savedInput = currentInput;


                                for (int l = 0; l < numbers.Length; l++)
                                {
                                    newArr[l] = int.Parse(numbers[l]);
                                }
                            }
                        }
                    }

                    count = 0;
                    sum = 0;
                }

                texts = Console.ReadLine();

                numbers = texts.Split("!", StringSplitOptions.RemoveEmptyEntries);

            }
            Console.WriteLine($"Best DNA sample {savedInput} with sum: {saveSum}.");
            Console.WriteLine($"{string.Join(" ", newArr)}");

        }
        else if (numbers.Length == 1)
        {
            while (texts != "Clone them!")
            {

                currentInput++;


                for (int j = 0; j < numbers.Length; j++)
                {
                    if (int.Parse(numbers[j]) == 1)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }

                }

                if (count > savedCount)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        sum += int.Parse(numbers[k]);
                    }

                    saveSum = sum;
                    savedIndex = currentIndex;
                    savedCount = count;
                    savedInput = currentInput;

                    for (int l = 0; l < numbers.Length; l++)
                    {
                        newArr[l] = int.Parse(numbers[l]);
                    }
                }
                else if (count == savedCount && currentIndex < savedIndex)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        sum += int.Parse(numbers[k]);
                    }

                    saveSum = sum;
                    savedIndex = currentIndex;
                    savedCount = count;
                    savedInput = currentInput;

                    for (int l = 0; l < numbers.Length; l++)
                    {
                        newArr[l] = int.Parse(numbers[l]);
                    }
                }
                else if (count == savedCount && currentIndex == savedIndex)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        sum += int.Parse(numbers[k]);
                    }

                    if (sum > saveSum)
                    {
                        saveSum = sum;
                        savedIndex = currentIndex;
                        savedCount = count;
                        savedInput = currentInput;

                        for (int l = 0; l < numbers.Length; l++)
                        {
                            newArr[l] = int.Parse(numbers[l]);
                        }
                    }

                }
                count = 0;
                sum = 0;

                texts = Console.ReadLine();

                numbers = texts.Split("!", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Best DNA sample {savedInput} with sum: {saveSum}.");
            Console.WriteLine($"{string.Join(" ", newArr)}");
        }
    }
}


