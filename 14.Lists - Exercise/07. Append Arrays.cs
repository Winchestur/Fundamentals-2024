using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|').ToList();

            List<string> newList = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                newList.Add(numbers[numbers.Count - 1 - i]);

            }

            newList = newList.SelectMany(item => item.Split(' ')).ToList();
            numbers = new List<string>();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] == string.Empty)
                {

                }
                else
                {
                    numbers.Add(newList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}