using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }

    public Person(string name, int id, int age)
    {
        Name = name;
        Id = id;
        Age = age;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> student = Console.ReadLine().Split().ToList();

        List<Person> persons = new List<Person>();

        while (student[0] != "End")
        {
            string nameOfPerson = student[0];
            int id = int.Parse(student[1]);
            int age = int.Parse(student[2]);

            Exist(persons, id);

            Person person = new Person(nameOfPerson, id, age);
            persons.Add(person);

            student = Console.ReadLine().Split().ToList();
        }

        persons = persons.OrderBy(p => p.Age).ToList();

        foreach (Person item in persons)
        {
            Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
        }
    }

    private static void Exist(List<Person> persons, int id)
    {
        int count = 0;

        foreach (Person items in persons)
        {
            if (items.Id == id)
            {
                persons.RemoveAt(count);
                break;
            }

            count++;
        }
    }
}