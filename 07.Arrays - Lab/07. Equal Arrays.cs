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
        int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int saveIndex = 0;
        int count = 0;
        int sum = 0;

        for (int i = 0; i < firstArr.Length; i++)
        {

            if (firstArr[i] == secondArr[i])
            {
                count++;
                sum += firstArr[i];
            }
            else if (firstArr[i] != secondArr[i])
            {
                saveIndex = i;
                break;
            }
        }

        if (count == firstArr.Length)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
        else
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {saveIndex} index");
        }
    }
}