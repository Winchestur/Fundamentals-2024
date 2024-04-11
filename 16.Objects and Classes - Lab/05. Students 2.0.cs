using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> text = Console.ReadLine().Split().ToList();

        List<Student> students = new List<Student>();

        while (text[0] != "end")
        {
            string name = text[0];
            string lastName = text[1];
            int age = int.Parse(text[2]);
            string town = text[3];

            Student student = new Student();

            student.FirstName = name;
            student.LastName = lastName;
            student.Age = age;
            student.HomeTown = town;

            exist(students, name);

            students.Add(student);

            text = Console.ReadLine().Split().ToList();
        }

        string homeTown = Console.ReadLine();

        List<Student> filteredStudents = students
            .Where(s => s.HomeTown == homeTown)
            .ToList();

        foreach (Student person in filteredStudents)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
        }
    }

    private static void exist(List<Student> students, string name)
    {
        int count = 0;

        foreach (Student items in students)
        {
            if (items.FirstName == name)
            {
                students.RemoveAt(count);
                break;
            }

            count++;
        }
    }
}

internal class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

}