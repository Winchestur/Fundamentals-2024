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
        int n = int.Parse(Console.ReadLine());

        int countOpen = 0;
        int countClose = 0;
        int unbalanced = 0;
        int balanced = 0;

        for (int i = 1; i <= n; i++)
        {
            string text = Console.ReadLine();

            if (text == "(")
            {
                countOpen++;
            }
            else if (text == ")")
            {
                countClose++;
            }

            if (countOpen - countClose > 1 || countClose > countOpen && unbalanced < 1)
            {
                unbalanced++;
            }
        }

        if (countOpen - countClose >= 1 || countClose > countOpen || unbalanced > 0)
        {
            Console.WriteLine("UNBALANCED");
        }
        else
        {
            Console.WriteLine("BALANCED");
        }
    }
}