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
        int n = int.Parse(Console.ReadLine());

        decimal result = 0;

        for (int i = 0; i < n; i++)
        {
            decimal numbers = decimal.Parse(Console.ReadLine());

            result += numbers;
        }

        Console.WriteLine(result);
    }
}