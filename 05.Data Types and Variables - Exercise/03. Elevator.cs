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
        int numPeople = int.Parse(Console.ReadLine());
        int capacityElevator = int.Parse(Console.ReadLine());

        int counts = numPeople / capacityElevator;

        if (numPeople % capacityElevator > 0)
        {
            counts++;
        }

        Console.WriteLine(counts);

    }
}