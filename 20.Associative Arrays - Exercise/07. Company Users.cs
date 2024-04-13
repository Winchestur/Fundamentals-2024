using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<string> companyName = Console.ReadLine()
            .Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        int count = 0;

        while (companyName[0] != "End")
        {
            string company = companyName[0];
            string employeeId = companyName[1];

            if (!dic.ContainsKey(company))
                dic.Add(company, new List<string>());

            foreach (var item in dic)
            {
                foreach (var VARIABLE in item.Value)
                {
                    if (item.Key == company && VARIABLE == employeeId)
                    {
                        count++;
                        break;
                    }
                }
            }

            if (count == 0)
            {
                dic[company].Add(employeeId);
            }

            count = 0;


            companyName = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var item in dic)
        {
            Console.WriteLine($"{item.Key}");

            foreach (var VARIABLE in item.Value)
            {
                Console.WriteLine($"-- {VARIABLE}");
            }
        }
    }
}