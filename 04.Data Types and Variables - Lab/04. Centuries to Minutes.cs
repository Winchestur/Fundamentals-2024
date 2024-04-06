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
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;
        double days = years * 365.2422;
        double hours = Math.Floor(days) * 24;
        double minutes = Math.Floor(hours) * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = " +
                          $"{Math.Floor(days)} days = {hours} hours = {minutes} minutes");

    }
}