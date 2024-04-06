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
        int n = int.Parse(Console.ReadLine());

        long result = 0;

        for (int i = 0; i < n; i++)
        {
            string nums = Console.ReadLine();

            string[] numbers = nums.Split(' ');

            long leftSide = long.Parse(numbers[0]);
            long rightSide = long.Parse(numbers[1]);

            if (leftSide > rightSide)
            {
                while (leftSide != 0)
                {
                    long takeLastNum = leftSide % 10;
                    leftSide /= 10;
                    result += takeLastNum;
                }
            }
            else
            {
                while (rightSide != 0)
                {
                    long takeLastNum = rightSide % 10;
                    rightSide /= 10;
                    result += takeLastNum;
                }
            }
            Console.WriteLine(Math.Abs(result));
            result = 0;
        }
    }
}