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
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, new List<string>());
                }
                dic[word].Add(synonym);

            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }

        }
    }
}