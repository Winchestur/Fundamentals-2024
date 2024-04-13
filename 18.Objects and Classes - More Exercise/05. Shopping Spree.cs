using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;
internal class Person
{
    public string Name { get; set; }
    public double Money { get; set; }
    public List<string> BagOfProducts { get; set; }

    public Person(string name, double money)
    {
        Name = name;
        Money = money;
        BagOfProducts = new List<string>();
    }
}
internal class Product
{
    public string Name { get; set; }
    public double Cost { get; set; }

    public Product(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }

}
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> people = Console.ReadLine()
            .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> products = Console.ReadLine()
            .Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<Person> listOfPeople = new List<Person>();
        List<Product> listOfProducts = new List<Product>();


        for (int i = 0; i < people.Count; i += 2)
        {
            Person personClass = new Person(people[i], double.Parse(people[i + 1]));

            listOfPeople.Add(personClass);
        }

        for (int i = 0; i < products.Count; i += 2)
        {
            Product productClass = new Product(products[i], double.Parse(products[i + 1]));

            listOfProducts.Add(productClass);
        }

        List<string> command = Console.ReadLine().Split().ToList();

        while (command[0] != "END")
        {
            string name = command[0];
            string product = command[1];

            foreach (Person person in listOfPeople)
            {
                if (person.Name == name)
                {
                    foreach (Product itemProduct in listOfProducts)
                    {
                        if (itemProduct.Name == product)
                        {
                            if (person.Money >= itemProduct.Cost)
                            {
                                person.Money -= itemProduct.Cost;
                                Console.WriteLine($"{person.Name} bought {itemProduct.Name}");

                                person.BagOfProducts.Add(product);

                            }
                            else
                            {
                                Console.WriteLine($"{person.Name} can't afford {itemProduct.Name}");
                            }
                        }
                    }
                }
            }
            command = Console.ReadLine().Split().ToList();
        }

        foreach (var VARIABLE in listOfPeople)
        {
            if (VARIABLE.BagOfProducts.Count < 1)
            {
                Console.WriteLine($"{VARIABLE.Name} - Nothing bought");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", VARIABLE.Name)} - {string.Join(", ", VARIABLE.BagOfProducts)}");
            }
        }
    }
}