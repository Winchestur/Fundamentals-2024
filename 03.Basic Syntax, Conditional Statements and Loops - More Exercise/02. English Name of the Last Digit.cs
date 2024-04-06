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
        int number = int.Parse(Console.ReadLine());

        int takeLastDigit = number % 10;

        string[] array = new string[] {"zero", "one" , "two", "three", "four" ,
            "five" , "six", "seven", "eight", "nine"};

        Console.WriteLine(array[takeLastDigit]);
    }
}