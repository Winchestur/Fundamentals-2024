using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        string products = Console.ReadLine();

        double sum = 0;

        while (products != "Start")
        {

            if (double.Parse(products) == 0.1 || double.Parse(products) == 0.2 ||
                double.Parse(products) == 0.5 || double.Parse(products) == 1 ||
                double.Parse(products) == 2)
            {
                sum += double.Parse(products);
            }
            else
            {
                Console.WriteLine($"Cannot accept {products}");
            }

            products = Console.ReadLine();
        }

        products = Console.ReadLine();

        while (products != "End")
        {
            if (products == "Nuts")
            {
                if (sum >= 2.0)
                {
                    sum -= 2.0;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (products == "Water")
            {
                if (sum >= 0.7)
                {
                    sum -= 0.7;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (products == "Crisps")
            {
                if (sum >= 1.5)
                {
                    sum -= 1.5;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (products == "Soda")
            {
                if (sum >= 0.8)
                {
                    sum -= 0.8;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (products == "Coke")
            {
                if (sum >= 1.0)
                {
                    sum -= 1.0;
                    Console.WriteLine($"Purchased {products.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }

            products = Console.ReadLine();
        }

        Console.WriteLine($"Change: {sum:F2}");
    }
}
