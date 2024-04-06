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
        char charsOne = char.Parse(Console.ReadLine());
        char charTwo = char.Parse(Console.ReadLine());
        char charsThree = char.Parse(Console.ReadLine());

        Console.Write($"{charsThree} {charTwo} {charsOne}");

    }
}