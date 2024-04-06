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
        string text = Console.ReadLine();

        BigInteger num = 0;
        string dataType = "";
        double number = 0.0;
        bool boolean;

        while (text != "END")
        {

            if (text.Contains(".") && double.TryParse(text, out number))
            {
                dataType = "floating point";
                Console.WriteLine($"{text} is {dataType} type");
            }
            else if (bool.TryParse(text, out boolean))
            {
                dataType = "boolean";
                Console.WriteLine($"{text} is {dataType} type");

            }
            else if (BigInteger.TryParse(text, out num))
            {
                dataType = "integer";
                Console.WriteLine($"{text} is {dataType} type");

            }
            else if (text.Length == 1)
            {
                dataType = "character";
                Console.WriteLine($"{text} is {dataType} type");

            }
            else
            {
                dataType = "string";
                Console.WriteLine($"{text} is {dataType} type");

            }

            text = Console.ReadLine();
        }

    }
}