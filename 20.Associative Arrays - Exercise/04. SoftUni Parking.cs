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
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> dic = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> cars = Console.ReadLine().Split().ToList();

                commands(cars, dic);

            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static void commands(List<string> cars, Dictionary<string, string> dic)
        {
            string name = cars[1];

            switch (cars[0])
            {
                case "register":

                    string licensePlate = cars[2];

                    if (!dic.ContainsKey(name))
                    {
                        dic.Add(name, licensePlate);
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }

                    break;
                case "unregister":

                    if (!dic.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        dic.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    break;
            }
        }
    }
}