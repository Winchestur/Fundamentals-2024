using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


internal class Program
{
    private static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();
        int rotations = int.Parse(Console.ReadLine());

        List<int> newArr = new List<int>(arr);

        int result = 0;

        for (int i = 0; i < rotations; i++)
        {
            newArr[0] = arr[0];
            arr.RemoveAt(0);
            arr.Add(newArr[0]);

        }

        Console.WriteLine(string.Join(" ", arr));
    }
}