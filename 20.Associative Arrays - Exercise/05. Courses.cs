using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Text.RegularExpressions;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> programingLanguages = Console.ReadLine()
                .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            while (programingLanguages[0] != "end")
            {
                string language = programingLanguages[0];
                string name = programingLanguages[1];

                if (!dic.ContainsKey(language))
                {
                    dic.Add(language, new List<string>());
                }

                dic[language].Add(name);

                programingLanguages = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}