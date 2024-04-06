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
        string username = Console.ReadLine();



        int count = 0;
        int countPassword = 0;

        char lastCharacter = '\0';
        string reversePassword = "";

        while (reversePassword != username)
        {
            if (countPassword == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }

            countPassword++;

            string password = Console.ReadLine();
            reversePassword = "";

            while (count < password.Length)
            {
                lastCharacter = password[password.Length - count - 1];
                reversePassword += lastCharacter;
                count++;
            }
            count = 0;

            if (reversePassword != username && countPassword < 4)
            {
                Console.WriteLine($"Incorrect password. Try again.");
            }
        }

        if (reversePassword == username)
        {
            Console.WriteLine($"User {username} logged in.");
        }
    }
}