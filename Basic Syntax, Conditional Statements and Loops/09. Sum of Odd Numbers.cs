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
        int n = int.Parse(Console.ReadLine());

        int result = 0;
        int count = 0;

        for (int i = 0; i < 100; i++)
        {
            if (count == n)
            {
                break;
            }
            if (i % 2 == 1)
            {
                count++;
                Console.WriteLine(i);
                result += i;
            }
        }

        Console.WriteLine($"Sum: {result}");
    }
}