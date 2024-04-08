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
        BigInteger[] arr = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

        List<BigInteger> list = new List<BigInteger>();

        BigInteger currentBiggestNum = 0;
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentBiggestNum = arr[i];

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (currentBiggestNum <= arr[j])
                {
                    count++;
                    break;
                }

            }
            if (count == 0)
            {
                list.Add(currentBiggestNum);
            }
            count = 0;
        }
        Console.WriteLine(string.Join(" ", list));
    }
}