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
        int n = int.Parse(Console.ReadLine());



        int[] firstArr = new int[n];
        int[] secondArr = new int[n];

        int countFirst = -1;
        int countSecond = 2;

        for (int i = 0; i < n; i++)
        {
            int[] arrNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            countFirst++;
            countSecond--;

            firstArr[i] = arrNums[countFirst];
            secondArr[i] = arrNums[countSecond];

            if (countFirst == 1)
            {
                countFirst = -1;
            }
            if (countSecond == 0)
            {
                countSecond = 2;
            }

        }

        Console.WriteLine(string.Join(" ", firstArr));
        Console.WriteLine(string.Join(" ", secondArr));
    }
}