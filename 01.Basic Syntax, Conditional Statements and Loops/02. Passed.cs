using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());

        if (grade >= 3.00)
        {
            Console.WriteLine($"Passed!");
        }
    }
}