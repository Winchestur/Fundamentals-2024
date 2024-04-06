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
        int N = int.Parse(Console.ReadLine());
        for (int i = 2; i <= N; i++)
        {
            string isPrime = "true";

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = "false";
                    break;
                }
            }

            Console.WriteLine("{0} -> {1}", i, isPrime);

        }

    }
}