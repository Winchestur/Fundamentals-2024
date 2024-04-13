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
            List<string> programingLanguages = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < programingLanguages.Count; i++)
            {
                if (!dic.ContainsKey(programingLanguages[i]))
                {
                    dic.Add(programingLanguages[i], 0);
                }

                dic[programingLanguages[i]]++;
            }

            foreach (var item in dic)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}