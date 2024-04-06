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
        double pounds = double.Parse(Console.ReadLine());

        double dollars = pounds * 1.31;

        Console.WriteLine($"{dollars:f3}");
    }
}