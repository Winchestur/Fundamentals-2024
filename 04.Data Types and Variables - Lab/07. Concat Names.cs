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
        string nameOne = Console.ReadLine();
        string nameTwo = Console.ReadLine();
        string delimiter = Console.ReadLine();

        Console.Write($"{nameOne}{delimiter}{nameTwo}");
    }
}