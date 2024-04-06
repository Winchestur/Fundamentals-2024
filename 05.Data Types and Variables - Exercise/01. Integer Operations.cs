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
        int numOne = int.Parse(Console.ReadLine());
        int numTwo = int.Parse(Console.ReadLine());
        int numThree = int.Parse(Console.ReadLine());
        int numFour = int.Parse(Console.ReadLine());

        int resultOne = numOne + numTwo;
        int resultTwo = resultOne / numThree;
        int resultThree = resultTwo * numFour;

        Console.WriteLine(resultThree);
    }
}