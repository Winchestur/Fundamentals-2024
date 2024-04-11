namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            double sumFirstCar = 0.0;
            double sumSecondCar = 0.0;

            //First car time 

            if (numbers.Count % 2 == 1)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    sumFirstCar += numbers[i];

                    if (numbers[i] == 0)
                    {
                        sumFirstCar = Math.Round(sumFirstCar * 0.80, 1);
                    }
                }

                //Second car time
                for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
                {
                    sumSecondCar += numbers[i];
                    if (numbers[i] == 0)
                    {
                        sumSecondCar = Math.Round(sumSecondCar * 0.80, 1);
                    }
                }

                if (sumFirstCar < sumSecondCar)
                {
                    Console.WriteLine($"The winner is left with total time: {sumFirstCar}");
                }
                else if (sumFirstCar > sumSecondCar)
                {
                    Console.WriteLine($"The winner is right with total time: {sumSecondCar}");
                }
            }
        }
    }
}