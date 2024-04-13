using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;
using static Family;
using static Person;

internal class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

internal class Family
{
    public Person Member { get; set; }

    public List<Person> ListOfPeople = new List<Person>();

    public List<Person> newList = new List<Person>();
    public void AddMembers(Person member)
    {
        ListOfPeople.Add(member);
    }

    public void GetOldestMember()
    {
        int currentAge = 0;


        foreach (Person members in ListOfPeople)
        {
            if (currentAge < members.Age)
            {
                newList.Clear();
                currentAge = members.Age;
                newList.Add(members);
            }
        }

        foreach (var item in newList)
        {
            Console.WriteLine(string.Join(" ", item.Name, item.Age));
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Person person = new Person(input[0], int.Parse(input[1]));

            family.AddMembers(person);
        }

        family.GetOldestMember();

    }
}