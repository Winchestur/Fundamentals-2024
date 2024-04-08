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
using static System.Net.Mime.MediaTypeNames;


internal class Program
{
    private static void Main(string[] args)
    {
        string[] textOne = Console.ReadLine().Split();
        string[] textTwo = Console.ReadLine().Split();

        for (int i = 0; i < textTwo.Length; i++)
        {


            if (textOne.Contains(textTwo[i]))
            {
                Console.Write($"{textTwo[i]} ");
            }
        }
    }
}