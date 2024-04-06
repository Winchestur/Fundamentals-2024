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
        int counter = int.Parse(Console.ReadLine());

        int[] arr = new int[counter];

        for (int i = 0; i < counter; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            arr[i] = numbers;
        }

        int[] reversedArr = new int[arr.Length];

        int count = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            reversedArr[count] = arr[i];
            count++;
        }

        Console.WriteLine(string.Join(" ", reversedArr));
    }
}