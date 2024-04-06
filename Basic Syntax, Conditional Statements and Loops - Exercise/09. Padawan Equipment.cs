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
        double budget = double.Parse(Console.ReadLine());
        int countOfStudents = int.Parse(Console.ReadLine());
        double priceOfLightSaber = double.Parse(Console.ReadLine());
        double priceOfRobes = double.Parse(Console.ReadLine());
        double priceOfBelts = double.Parse(Console.ReadLine());

        double freeBelts = 0;

        if (countOfStudents < 6)
        {
            freeBelts = 0;
        }
        else
        {
            freeBelts = countOfStudents / 6;
        }


        double neededEquipment = priceOfLightSaber * (countOfStudents + Math.Ceiling(countOfStudents * 0.10)) +
                                 priceOfRobes * (countOfStudents) + priceOfBelts * (countOfStudents - freeBelts);

        if (neededEquipment <= budget)
        {
            Console.WriteLine($"The money is enough - it would cost {neededEquipment:F2}lv.");
        }
        else
        {
            double result = neededEquipment - budget;
            Console.WriteLine($"John will need {result:F2}lv more.");
        }
    }
}