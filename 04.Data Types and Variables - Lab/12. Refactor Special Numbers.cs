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
        int numbers = 0;
        bool isTrue = false;

        for (int i = 1; i <= count; i++)
        {
            numbers = i;
            while (i > 0)
            {
                result += i % 10;
                i = i / 10;
            }
            isTrue = (result == 5) || (result == 7) || (result == 11);
            Console.WriteLine("{0} -> {1}", numbers, isTrue);
            result = 0;
            i = numbers;
        }

    }
}