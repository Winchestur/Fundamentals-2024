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
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 30;

        while (minutes >= 60)
        {
            hours++;
            minutes -= 60;

            if (hours > 23)
            {
                hours = 0;
            }
        }



        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}