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
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            SortedDictionary<int, int> dic = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!dic.ContainsKey(numbers[i]))
                {
                    dic.Add(numbers[i], 0);
                }

                dic[numbers[i]]++;
            }



            foreach (KeyValuePair<int, int> item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}