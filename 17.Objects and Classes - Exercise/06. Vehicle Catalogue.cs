using System.ComponentModel;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal HorsePower { get; set; }

    public Vehicle(string type, string model, string color, decimal horsePower)
    {
        if (type == "car")
        {
            Type = "Car";
        }
        else if (type == "truck")
        {
            Type = "Truck";
        }

        Model = model;
        Color = color;
        HorsePower = horsePower;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<string> cars = Console.ReadLine().Split().ToList();

        int count = 0;


        string type = "";
        string model = "";
        string color = "";
        decimal horsePower = 0;

        List<Vehicle> vehicles = new List<Vehicle>();
        Vehicle vehicle = new Vehicle(type, model, color, horsePower);

        int countCar = 0;
        int countTruck = 0;
        decimal avrCar = 0;
        decimal avrTruck = 0;

        while (cars[0] != "End")
        {
            type = cars[0];
            model = cars[1];
            color = cars[2];
            horsePower = decimal.Parse(cars[3]);

            vehicle = new Vehicle(type, model, color, horsePower);
            vehicles.Add(vehicle);

            cars = Console.ReadLine().Split().ToList();
        }

        string randomText = Console.ReadLine();

        while (randomText != "Close the Catalogue")
        {
            foreach (Vehicle car in vehicles)
            {
                if (car.Model == randomText)
                {
                    if (car.Type == "Truck" || car.Type == "Car")
                    {
                        Console.WriteLine($"Type: {car.Type}");


                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }
            }

            randomText = Console.ReadLine();
        }

        decimal totalCarHp = vehicles
            .Where(c => c.Type == "Car")
            .Select(c => c.HorsePower)
            .DefaultIfEmpty()
            .Average();

        decimal totalTruckHp = vehicles
            .Where(t => t.Type == "Truck")
            .Select(t => t.HorsePower)
            .DefaultIfEmpty()
            .Average();


        Console.WriteLine($"Cars have average horsepower of: {totalCarHp:F2}.");

        Console.WriteLine($"Trucks have average horsepower of: {totalTruckHp:F2}.");

    }
}