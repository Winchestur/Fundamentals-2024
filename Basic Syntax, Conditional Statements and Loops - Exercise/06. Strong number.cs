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
        int number = int.Parse(Console.ReadLine());

        int takeNumber = number;
        int sum = 1;
        int totalResult = 0;

        while (takeNumber > 0)
        {
            int takeLastNum = takeNumber % 10;
            takeNumber /= 10;

            for (int i = takeLastNum; i >= 1; i--)
            {
                sum *= i;
            }
            totalResult += sum;
            sum = 1;
        }

        if (totalResult == number)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}