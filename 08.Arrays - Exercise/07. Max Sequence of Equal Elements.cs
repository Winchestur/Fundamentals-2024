using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] newArr = new int[numbers.Length];

        int index = 0;
        int currentNumber = 0;
        int count = 1;
        int saveCount = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            index = i;
            currentNumber = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (currentNumber == numbers[j])
                {
                    count++;
                }
                else if (currentNumber != numbers[j])
                {
                    break;
                }
            }

            int saveIndex = index;

            if (count > saveCount)
            {
                saveCount = count;
                newArr = new int[count];

                for (int k = 0; k < count; k++)
                {
                    newArr[k] = numbers[saveIndex];
                }
            }
            count = 1;
        }

        Console.WriteLine(string.Join(" ", newArr));
    }
}