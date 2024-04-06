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
        double currentBalance = double.Parse(Console.ReadLine());

        string games = Console.ReadLine();

        double totalSum = 0.0;

        while (games != "Game Time")
        {
            if (games == "OutFall 4")
            {
                if (currentBalance >= 39.99)
                {
                    currentBalance -= 39.99;
                    Console.WriteLine($"Bought {games}");
                    totalSum += 39.99;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            else if (games == "CS: OG")
            {
                if (currentBalance >= 15.99)
                {
                    currentBalance -= 15.99;
                    Console.WriteLine($"Bought {games}");
                    totalSum += 15.99;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

            }

            else if (games == "Zplinter Zell")
            {
                if (currentBalance >= 19.99)
                {
                    currentBalance -= 19.99;
                    Console.WriteLine($"Bought {games}");
                    totalSum += 19.99;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            else if (games == "Honored 2")
            {
                if (currentBalance >= 59.99)
                {
                    currentBalance -= 59.99;
                    Console.WriteLine($"Bought {games}");
                    totalSum += 59.99;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            else if (games == "RoverWatch")
            {
                if (currentBalance >= 29.99)
                {
                    currentBalance -= 29.99;
                    Console.WriteLine($"Bought {games}");
                    totalSum += 29.99;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            else if (games == "RoverWatch Origins Edition")
            {
                if (currentBalance >= 39.99)
                {
                    currentBalance -= 39.99;
                    Console.WriteLine($"Bought {games}");
                    totalSum += 39.99;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }

            else
            {
                Console.WriteLine("Not Found");
            }

            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }

            games = Console.ReadLine();
        }

        if (currentBalance > 0)
        {
            Console.WriteLine($"Total spent: ${totalSum:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
