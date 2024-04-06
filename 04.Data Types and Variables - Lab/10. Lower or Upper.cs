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
        string text = Console.ReadLine();

        if (text == text.ToLower())
        {
            Console.WriteLine("lower-case");
        }
        else if (text == text.ToUpper())
        {
            Console.WriteLine("upper-case");
        }
    }
}