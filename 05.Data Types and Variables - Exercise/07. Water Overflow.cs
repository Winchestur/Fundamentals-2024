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


        int capacity = 255;
        int pouredWater = 0;

        for (int i = 0; i < count; i++)
        {

            int liters = int.Parse(Console.ReadLine());

            pouredWater += liters;

            if (pouredWater > capacity)
            {
                pouredWater -= liters;
                Console.WriteLine($"Insufficient capacity!");
            }
        }

        Console.WriteLine(pouredWater);
    }
}