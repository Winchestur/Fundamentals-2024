using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {

            List<string> list = Console.ReadLine().Split().ToList();
            Employee person = new Employee(list[0], double.Parse(list[1]), list[2]);

            employees.Add(person);


        }

        employees = employees.OrderBy(e => e.Department).ToList();

        int count = 0;
        double result = 0;
        double saveResult = 0;
        string currentDepartment = "";
        int counter = 0;
        int times = 0;

        List<Employee> newList = new List<Employee>();
        List<Employee> saveList = new List<Employee>();

        foreach (Employee person in employees)
        {
            if (count == 0)
            {
                currentDepartment = person.Department;
                newList.Add(person);
                result += person.Salary;
                count++;
            }

            else if (currentDepartment == person.Department)
            {
                newList.Add(person);
                result += person.Salary;
                count++;
            }

            else if (currentDepartment != person.Department)
            {
                result /= count;
                count = 0;

                if (result > saveResult)
                {
                    saveList = new List<Employee>();
                    saveResult = result;
                    saveList.AddRange(newList);
                    result = 0;
                }

                if (count == 0)
                {
                    newList = new List<Employee>();

                    currentDepartment = person.Department;
                    newList.Add(person);
                    result += person.Salary;
                    count++;
                }

            }

            times++;
            if (times == employees.Count)
            {
                result /= count;
                count = 0;

                if (result > saveResult)
                {
                    saveList = new List<Employee>();
                    saveResult = result;
                    saveList.AddRange(newList);
                    result = 0;
                }
            }
        }

        saveList = saveList.OrderByDescending(e => e.Salary).ToList();


        foreach (Employee item in saveList)
        {
            if (counter == 0)
            {
                Console.WriteLine($"Highest Average Salary: {item.Department}");
                Console.WriteLine($"{item.Name} {item.Salary:F2}");
                counter++;
            }
            else
            {
                Console.WriteLine($"{item.Name} {item.Salary:F2}");
            }
        }
    }
}