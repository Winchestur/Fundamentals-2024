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
        int counts = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 0; i < counts; i++)
        {
            char letters = char.Parse(Console.ReadLine());

            result += letters;
        }

        Console.WriteLine($"The sum equals: {result}");
    }
}