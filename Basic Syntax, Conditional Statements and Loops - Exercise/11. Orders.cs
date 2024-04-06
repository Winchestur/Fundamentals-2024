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
        int countOfOrders = int.Parse(Console.ReadLine());

        double result = 0.0;
        double totalSum = 0.0;

        for (int i = 0; i < countOfOrders; i++)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsuleCount = int.Parse(Console.ReadLine());

            result = pricePerCapsule * days * capsuleCount;

            totalSum += result;

            Console.WriteLine($"The price for the coffee is: ${result:F2}");
        }

        Console.WriteLine($"Total: ${totalSum:F2}");
    }
}