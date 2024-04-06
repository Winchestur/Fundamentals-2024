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
        int meters = int.Parse(Console.ReadLine());

        double metersToKm = meters / 1000.0;

        Console.WriteLine($"{metersToKm:F2}");
    }
}