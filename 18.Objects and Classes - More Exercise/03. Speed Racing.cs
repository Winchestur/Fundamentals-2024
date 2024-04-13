using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Transactions;
using System.Xml.Linq;
using static Car;

internal class Car
{
    public string CarModel { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKm { get; set; }
    public double TraveledDistance { get; set; }

    public Car(string carModel, double fuelAmount, double fuelConsumptionPerKm)
    {
        CarModel = carModel;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public override string ToString()
    {
        return $"{CarModel} {FuelAmount:F2} {TraveledDistance}";
    }

    public void IfItMoves(double traveledDistance)
    {
        if (FuelAmount >= FuelConsumptionPerKm * traveledDistance)
        {
            FuelAmount -= FuelConsumptionPerKm * traveledDistance;
            TraveledDistance += traveledDistance;
        }
        else
        {
            Console.WriteLine($"Insufficient fuel for the drive");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Car> newCars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            List<string> cars = Console.ReadLine().Split().ToList();

            Car carModels = new Car(cars[0], double.Parse(cars[1]), double.Parse(cars[2]));

            newCars.Add(carModels);
        }

        List<string> commands = Console.ReadLine().Split().ToList();

        while (commands[0] != "End")
        {
            string carModel = commands[1];
            double amountOfKm = double.Parse(commands[2]);

            switch (commands[0])
            {
                case "Drive":

                    foreach (Car car in newCars)
                    {
                        if (car.CarModel == carModel)
                        {
                            car.IfItMoves(amountOfKm);

                            break;
                        }
                    }
                    break;
            }

            commands = Console.ReadLine().Split().ToList();
        }

        Console.WriteLine(string.Join(Environment.NewLine, newCars));
    }
}