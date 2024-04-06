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
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());

        Console.Write($"Name: {name}, Age: {age}, Grade: {grade:F2}");

    }
}

