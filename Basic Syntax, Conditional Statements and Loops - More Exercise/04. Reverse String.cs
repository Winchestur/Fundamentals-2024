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
        string text = Console.ReadLine();

        char[] chars = text.ToCharArray();

        string reversed = "";

        for (int i = chars.Length - 1; i >= 0; i--)
        {
            reversed += chars[i];
        }

        Console.WriteLine(reversed);
    }
}