using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Text.RegularExpressions;

namespace Judge
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalResult => Price * Quantity;

        public override string ToString()
        {
            return $"{Name} -> {TotalResult:F2}";
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split().ToList();

            Dictionary<string, Product> dic = new Dictionary<string, Product>();

            List<Product> product = new List<Product>();

            while (products[0] != "buy")
            {
                string productName = products[0];
                double price = double.Parse(products[1]);
                int quantity = int.Parse(products[2]);

                Product productClass = new Product(productName, price, quantity);

                if (!dic.ContainsKey(productName))
                {
                    dic.Add(productName, productClass);
                }
                else if (dic.ContainsKey(productName))
                {
                    dic[productName].Price = price;
                    dic[productName].Quantity += quantity;

                }


                products = Console.ReadLine().Split().ToList();
            }

            foreach (var item in dic)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}