using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Text.RegularExpressions;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = Console.ReadLine().Split().ToList();

            List<string> result = new List<string>();

            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Length % 2 == 0)
                {
                    result.Add(fruits[i]);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}