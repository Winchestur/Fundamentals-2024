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
        int startingYield = int.Parse(Console.ReadLine());

        int leaved = 0;
        int count = 0;

        while (startingYield >= 100)
        {
            count++;
            leaved += startingYield - 26;

            startingYield -= 10;

        }

        if (leaved >= 26)
        {
            leaved -= 26;
        }

        Console.WriteLine($"{count}");
        Console.WriteLine($"{leaved}");
    }
}