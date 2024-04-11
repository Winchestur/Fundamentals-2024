using System.ComponentModel;
using System.Numerics;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> text = Console.ReadLine().Split().ToList();

        Random randomText = new Random();

        for (int i = 0; i < text.Count; i++)
        {
            int indexOne = randomText.Next(0, text.Count);
            int indexTwo = randomText.Next(0, text.Count);

            string firstWord = text[indexOne];
            string secondWord = text[indexTwo];

            if (indexOne != indexTwo && indexOne >= 0 && indexOne < text.Count &&
                indexTwo >= 0 && indexTwo < text.Count)
            {
                text.RemoveAt(indexOne);
                text.Insert(indexOne, secondWord);
                text.RemoveAt(indexTwo);
                text.Insert(indexTwo, firstWord);
            }
        }

        foreach (string item in text)
        {
            Console.WriteLine(item);
        }
    }
}