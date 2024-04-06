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
        int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondArr = new int[firstArr.Length - 1];

        while (firstArr.Length > 1)
        {
            for (int i = 0; i < firstArr.Length - 1; i++)
            {
                for (int j = i + 1; j <= i + 1; j++)
                {
                    secondArr[i] = firstArr[i] + firstArr[j];
                }
            }

            firstArr = new int[secondArr.Length];

            for (int k = 0; k < secondArr.Length; k++)
            {
                firstArr[k] = secondArr[k];
            }
            secondArr = new int[firstArr.Length - 1];
        }

        Console.WriteLine(string.Join(" ", firstArr));
    }
}