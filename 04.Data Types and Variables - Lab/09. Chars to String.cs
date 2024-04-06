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
        char charOne = char.Parse(Console.ReadLine());
        char charTwo = char.Parse(Console.ReadLine());
        char charThree = char.Parse(Console.ReadLine());

        string text = "";

        text += charOne;
        text += charTwo;
        text += charThree;

        Console.WriteLine(text);
    }
}