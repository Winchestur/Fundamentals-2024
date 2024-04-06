using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double[] arr = new double[] { num1, num2, num3 };


            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr);
                Array.Reverse(arr);
                Console.WriteLine(arr[i]);
            }

        }
    }
}