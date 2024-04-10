using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());


        int[] sumOfLetters = new int[n];

        int result = 0;
        int count = 0;
        int counter = 1;

        while (counter <= n)
        {
            string text = Console.ReadLine();

            foreach (char item in text)
            {
                if ("aeiou".Contains(item) || "AEIOU".Contains(item))
                {
                    result += item * text.Length;
                }
                else
                {
                    result += item / text.Length;
                }
            }

            sumOfLetters[count] = result;

            result = 0;

            count++;
            counter++;
        }

        Array.Sort(sumOfLetters);

        for (int i = 0; i < sumOfLetters.Length; i++)
        {
            Console.WriteLine(sumOfLetters[i]);
        }
    }
}