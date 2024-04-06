using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        //bool areEqual = Math.Abs(num1 - num2) < eps;

        if (Math.Abs(num1 - num2) < eps)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}