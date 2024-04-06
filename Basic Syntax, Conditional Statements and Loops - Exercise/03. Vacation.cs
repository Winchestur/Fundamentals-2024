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
        int numOfPeople = int.Parse(Console.ReadLine());
        string typeOfGroup = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();

        double price = 0.0;


        switch (dayOfWeek)
        {
            case "Friday":

                if (typeOfGroup == "Students")
                {
                    price = numOfPeople * 8.45;

                    if (numOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    price = numOfPeople * 10.90;

                    if (numOfPeople >= 100)
                    {
                        price -= 10 * 10.90;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    price = numOfPeople * 15;

                    if (numOfPeople > 10 && numOfPeople < 20)
                    {
                        price *= 0.95;
                    }
                }

                break;
            case "Saturday":

                if (typeOfGroup == "Students")
                {
                    price = numOfPeople * 9.80;

                    if (numOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    price = numOfPeople * 15.60;

                    if (numOfPeople >= 100)
                    {
                        price -= 10 * 15.60;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    price = numOfPeople * 20;

                    if (numOfPeople > 10 && numOfPeople < 20)
                    {
                        price *= 0.95;
                    }
                }

                break;
            case "Sunday":

                if (typeOfGroup == "Students")
                {
                    price = numOfPeople * 10.46;

                    if (numOfPeople >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    price = numOfPeople * 16;

                    if (numOfPeople >= 100)
                    {
                        price -= 10 * 16;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    price = numOfPeople * 22.50;

                    if (numOfPeople > 10 && numOfPeople < 20)
                    {
                        price *= 0.95;
                    }
                }

                break;
        }

        Console.WriteLine($"Total price: {price:F2}");
    }
}
