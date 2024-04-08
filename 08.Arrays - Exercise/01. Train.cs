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

        int[] array = new int[n];
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            array[i] = numbers;
            result += numbers;
        }

        Console.WriteLine(string.Join(" ", array));
        Console.WriteLine(result);
    }
}