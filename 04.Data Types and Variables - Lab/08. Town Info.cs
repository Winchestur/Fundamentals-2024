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
        string town = Console.ReadLine();
        int population = int.Parse(Console.ReadLine());
        int area = int.Parse(Console.ReadLine());

        Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
    }
}