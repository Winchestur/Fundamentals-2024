using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double HorsePower { get; set; }

    public Car(string brand, string model, double horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }
}

internal class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Weight { get; set; }

    public Truck(string brand, string model, double weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
}

internal class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }

    public Catalog(List<Car> cars, List<Truck> trucks)
    {
        Cars = cars;
        Trucks = trucks;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> carList = Console.ReadLine().Split("/").ToList();

        List<Truck> truck = new List<Truck>();
        List<Car> car = new List<Car>();

        while (carList[0] != "end")
        {
            Operations(carList, car, truck);


            carList = Console.ReadLine().Split("/").ToList();
        }

        Catalog catalog = new Catalog(car, truck);


        if (catalog.Cars.Count > 0)
        {
            Console.WriteLine($"Cars:");

            foreach (Car cars in catalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{cars.Brand}: {cars.Model} - {cars.HorsePower}hp");
            }
        }

        if (catalog.Trucks.Count > 0)
        {
            Console.WriteLine($"Trucks:");

            foreach (Truck trucks in catalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{trucks.Brand}: {trucks.Model} - {trucks.Weight}kg");
            }
        }
    }

    private static void Operations(List<string> carList, List<Car> car, List<Truck> truck)
    {
        switch (carList[0])
        {
            case "Car":

                string brand = carList[1];
                string model = carList[2];
                double horsePower = double.Parse(carList[3]);

                Car cars = new Car(brand, model, horsePower);

                car.Add(cars);

                break;
            case "Truck":
                brand = carList[1];
                model = carList[2];
                double weight = double.Parse(carList[3]);

                Truck trucks = new Truck(brand, model, weight);

                truck.Add(trucks);
                break;
        }
    }
}