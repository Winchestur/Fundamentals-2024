using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<string> list = new List<string>()
        {
            "January", "February" , "March", "April", "May", "June", 
            "July", "August", "September", "October", "November", "December"
        };

        Console.WriteLine(list[num-1]);
        
    }
}