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
using static System.Net.Mime.MediaTypeNames;


internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rightSideSum = 0;
        int LeftSideSum = 0;
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int rightSide = i + 1; rightSide < numbers.Length; rightSide++)
            {
                rightSideSum += numbers[rightSide];
            }

            for (int leftSide = i - 1; leftSide >= 0; leftSide--)
            {
                LeftSideSum += numbers[leftSide];
            }

            if (rightSideSum == LeftSideSum)
            {
                count++;
                Console.WriteLine(i);
                break;
            }

            rightSideSum = 0;
            LeftSideSum = 0;
        }

        if (count < 1)
        {
            Console.WriteLine("no");
        }
    }
}