using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;

internal class Car
{
    public string Model { get; set; }
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }

    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        EngineSpeed = engine.EngineSpeed;
        EnginePower = engine.EnginePower;
        CargoWeight = cargo.CargoWeight;
        CargoType = cargo.CargoType;
    }
}
internal class Engine
{
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
    public Engine(int engineSpeed, int enginePower)
    {
        EngineSpeed = engineSpeed;
        EnginePower = enginePower;
    }
}
internal class Cargo
{
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }

    public Cargo(int cargoWeight, string cargoType)
    {
        CargoWeight = cargoWeight;
        CargoType = cargoType;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Car> newCar = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            List<string> cars = Console.ReadLine().Split().ToList();

            Car car = new Car(cars[0], new Engine(int.Parse(cars[1]), int.Parse(cars[2])),
                new Cargo(int.Parse(cars[3]), cars[4]));

            newCar.Add(car);
        }

        string type = Console.ReadLine();

        foreach (Car car in newCar)
        {
            switch (type)
            {
                case "fragile":

                    if (car.CargoType == "fragile" && car.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                case "flamable":

                    if (car.CargoType == "flamable" && car.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
            }
        }
    }
}