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
            List<string> text = Console.ReadLine().Split().ToList();

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < text.Count; i++)
            {

                for (int j = 0; j < text[i].Length; j++)
                {

                    if (!dic.ContainsKey(text[i][j].ToString()))
                    {
                        dic.Add(text[i][j].ToString(), 0);
                    }

                    dic[text[i][j].ToString()]++;

                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}