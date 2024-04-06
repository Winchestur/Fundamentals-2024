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
        byte n = byte.Parse(Console.ReadLine());

        double saveQuallity = 0.0;
        BigInteger saveValue = 0;
        double saveTime = 0.0;
        double saveSnowball = 0.0;
        BigInteger result = 0;
        BigInteger snowballValue = 1;

        for (int i = 1; i <= n; i++)
        {
            ushort snowballSnow = ushort.Parse(Console.ReadLine());
            ushort snowballTime = ushort.Parse(Console.ReadLine());
            byte snowballQuallity = byte.Parse(Console.ReadLine());


            result = snowballSnow / snowballTime;

            for (int j = 1; j <= snowballQuallity; j++)
            {
                snowballValue *= result;
            }

            if (snowballValue > saveValue)
            {
                saveValue = snowballValue;
                saveTime = snowballTime;
                saveSnowball = snowballSnow;
                saveQuallity = snowballQuallity;
            }
            snowballValue = 1;
        }

        Console.WriteLine($"{saveSnowball} : {saveTime} = {saveValue} ({saveQuallity})");
    }
}