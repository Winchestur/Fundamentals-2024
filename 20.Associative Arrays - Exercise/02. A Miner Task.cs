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
            string resource = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Dictionary<string, int> dic = new Dictionary<string, int>();

            while (resource != "stop")
            {
                if (!dic.ContainsKey(resource))
                {
                    dic.Add(resource, 0);
                }

                dic[resource] += quantity;

                resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}