

using System.Diagnostics.SymbolStore;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int takeLastNumber = 0;
            int takeFirstNumber = 0;
            int sum = 0;
            int takeRemovedNumber = 0;

            while (numbers.Count > 0)
            {
                int indexes = int.Parse(Console.ReadLine());

                if (indexes >= 0 && indexes < numbers.Count)
                {
                    takeRemovedNumber = numbers[indexes];
                    sum += numbers[indexes];
                    numbers.RemoveAt(indexes);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > takeRemovedNumber)
                        {
                            numbers[i] -= takeRemovedNumber;
                        }
                        else
                        {
                            numbers[i] += takeRemovedNumber;
                        }
                    }
                }
                else if (indexes < 0)
                {
                    takeLastNumber = numbers[numbers.Count - 1];
                    sum += numbers[0];
                    takeFirstNumber = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Insert(0, takeLastNumber);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > takeFirstNumber)
                        {
                            numbers[i] -= takeFirstNumber;
                        }
                        else
                        {
                            numbers[i] += takeFirstNumber;
                        }
                    }
                }
                else
                {
                    takeFirstNumber = numbers[0];
                    sum += numbers[numbers.Count - 1];
                    takeLastNumber = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Add(takeFirstNumber);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > takeLastNumber)
                        {
                            numbers[i] -= takeLastNumber;
                        }
                        else
                        {
                            numbers[i] += takeLastNumber;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
