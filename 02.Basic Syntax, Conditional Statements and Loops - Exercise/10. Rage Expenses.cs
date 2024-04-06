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
        int lostGameCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboard = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        double countHeadset = 0;
        double countMouse = 0;
        double countKeyboard = 0;
        double countDisplay = 0;

        double trashedHeadset = 0;
        double trashedMouse = 0;
        double trashedKeyboard = 0;
        double trashedDisplay = 0;
        double totalCountMouse = 0;
        double totalCountHeadset = 0;

        for (int i = 1; i <= lostGameCount; i++)
        {
            countHeadset++;
            countMouse++;

            if (countHeadset == 2)
            {
                trashedHeadset++;
                totalCountHeadset += countHeadset;
                countHeadset = 0;
            }
            if (countMouse == 3)
            {
                trashedMouse++;
                totalCountMouse += countMouse;
                countMouse = 0;
            }
            if (totalCountHeadset == totalCountMouse && totalCountHeadset > 0)
            {
                trashedKeyboard++;
                countKeyboard++;
                totalCountMouse = 0;
                totalCountHeadset = 0;

                if (countKeyboard == 2)
                {
                    trashedDisplay++;
                    countKeyboard = 0;
                }
            }

        }
        double result = trashedHeadset * headsetPrice + trashedMouse * mousePrice +
            trashedKeyboard * keyboard + trashedDisplay * displayPrice;

        Console.WriteLine($"Rage expenses: {result:F2} lv.");
    }
}
