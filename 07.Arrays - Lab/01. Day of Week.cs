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
        int days = int.Parse(Console.ReadLine());

        string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday"};

        if (days >= 1 && days <= 7)
        {
            Console.WriteLine(daysOfWeek[days - 1]);
        }
        else
        {
            Console.WriteLine("Invalid day!");
        }
    }
}