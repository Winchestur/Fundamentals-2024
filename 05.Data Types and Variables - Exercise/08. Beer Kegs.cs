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

        double result = 0.0;
        double savedResult = 0.0;
        string savedModel = "";

        for (int i = 0; i < count; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            result = Math.PI * Math.Pow(radius, 2) * height;

            if (result > savedResult)
            {
                savedModel = model;
                savedResult = result;
            }

        }
        Console.WriteLine(savedModel);
    }
}