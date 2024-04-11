using System.Xml.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSets = Console.ReadLine()
                .Split().Select(int.Parse).ToList();

            practice(savings, drumSets);
        }

        private static void practice(double savings, List<int> drumSets)
        {
            List<int> saveDrumSets = new List<int>();

            for (int i = 0; i < drumSets.Count; i++)
            {
                saveDrumSets.Add(drumSets[i]);
            }

            string hitPower = Console.ReadLine();

            while (hitPower != "Hit it again, Gabsy!")
            {

                int PowerOfHit = int.Parse(hitPower);

                for (int i = 0; i < saveDrumSets.Count; i++)
                {
                    saveDrumSets[i] -= PowerOfHit;

                    if (saveDrumSets[i] <= 0)
                    {
                        if (savings >= drumSets[i] * 3)
                        {
                            savings -= drumSets[i] * 3;
                            saveDrumSets[i] = drumSets[i];
                        }
                        else
                        {
                            saveDrumSets.RemoveAt(i);
                            drumSets.RemoveAt(i);
                            i = i - 1;
                        }
                    }
                }

                hitPower = Console.ReadLine();
            }

            Console.WriteLine($"{string.Join(" ", saveDrumSets)}");
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}