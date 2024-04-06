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
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger M = BigInteger.Parse(Console.ReadLine());
        byte Y = byte.Parse(Console.ReadLine());

        int count = 0;
        BigInteger takeN = N;
        BigInteger halfN = 0;

        if (takeN % 2 == 0)
        {
            halfN = takeN / 2;
        }

        while (N >= M)
        {

            N -= M;
            count++;


            if (N == halfN)
            {
                if (N >= Y && Y > 0)
                {
                    N /= Y;
                }
                else
                {
                    continue;
                }
            }
        }
        Console.WriteLine(N);
        Console.WriteLine(count);
    }
}