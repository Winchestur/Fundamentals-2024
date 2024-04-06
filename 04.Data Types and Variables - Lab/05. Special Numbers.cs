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

        int result = 0;

        for (int i = 1; i <= count; i++)
        {
            int takeI = i;
            while (takeI > 0)
            {
                int takeLastNum = takeI % 10;
                result += takeLastNum;
                takeI /= 10;

            }
            if (result == 5 || result == 7 || result == 11)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
            result = 0;

        }
    }
}