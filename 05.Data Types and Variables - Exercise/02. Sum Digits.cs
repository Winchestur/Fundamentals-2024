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
        int number = int.Parse(Console.ReadLine());

        int result = 0;

        while (number > 0)
        {
            int takeLast = number % 10;
            number /= 10;
            result += takeLast;
        }

        Console.WriteLine(result);
    }
}