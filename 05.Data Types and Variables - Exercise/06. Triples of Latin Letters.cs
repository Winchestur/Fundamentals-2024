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
        int count = int.Parse(Console.ReadLine());


        for (int first = 97; first < 97 + count; first++)
        {
            for (int second = 97; second < 97 + count; second++)
            {
                for (int third = 97; third < 97 + count; third++)
                {
                    Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                }
            }
        }

    }
}