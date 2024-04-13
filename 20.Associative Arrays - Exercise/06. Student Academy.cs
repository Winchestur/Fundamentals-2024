using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Text.RegularExpressions;



class Grade
{
    public string Name { get; set; }
    public double GradeOfPerson { get; set; }
    public int Counter { get; set; }

    public double Total => GradeOfPerson / Counter;

    public Grade(string name, double gradeOfPerson)
    {
        Name = name;
        GradeOfPerson += gradeOfPerson;
        Counter = 0;
    }

    public override string ToString()
    {
        return $"{Name} -> {Total:F2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Grade> dic = new Dictionary<string, Grade>();

        for (int i = 0; i < n; i++)
        {


            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            Grade grades = new Grade(name, grade);

            if (!dic.ContainsKey(name))
            {
                dic.Add(name, grades);
                dic[name].Counter++;
            }
            else
            {
                dic[name].GradeOfPerson += grade;
                dic[name].Counter++;
            }
        }


        foreach (var VARIABLE in dic)
        {
            if (VARIABLE.Value.Total >= 4.5)
            {
                Console.WriteLine($"{VARIABLE.Value}");
            }
        }
    }
}