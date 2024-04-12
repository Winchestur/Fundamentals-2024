using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int counter = int.Parse(Console.ReadLine());

        List<Student> newStudents = new List<Student>();

        for (int i = 0; i < counter; i++)
        {
            List<string> students = Console.ReadLine().Split().ToList();

            string studentName = students[0];
            string studentLastName = students[1];
            double grade = double.Parse(students[2]);

            Student Students = new Student(studentName, studentLastName, grade);

            newStudents.Add(Students);

        }

        newStudents = newStudents.OrderByDescending(s => s.Grade).ToList();

        foreach (Student student in newStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
        }
    }
}