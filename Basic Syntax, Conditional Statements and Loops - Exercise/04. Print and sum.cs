using System;
using System.Collections.Generic;
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
        int startNum = int.Parse(Console.ReadLine());
        int EndNum = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = startNum; i <= EndNum; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }

        Console.WriteLine();
        Console.WriteLine($"Sum: {sum}");

    }
}