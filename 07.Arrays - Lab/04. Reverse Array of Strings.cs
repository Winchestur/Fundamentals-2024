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
        string[] arr = Console.ReadLine().Split();

        int counter = 0;
        string[] reversedArr = new string[arr.Length];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            reversedArr[counter] = arr[i];
            counter++;
        }

        Console.WriteLine(string.Join(" ", reversedArr));
    }
}