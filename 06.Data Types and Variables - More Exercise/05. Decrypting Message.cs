using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());


        string decryptText;

        for (int i = 0; i < n; i++)
        {
            char chars = char.Parse(Console.ReadLine());
            chars += (char)key;

            decryptText = chars.ToString();

            Console.Write($"{decryptText}");
        }

    }
}