namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> list = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            decimal[] bomb = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            if (bomb.Length == 2)
            {
                decimal bombNumber = bomb[0];
                decimal power = bomb[1];

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == bombNumber)
                    {
                        if (i + power < list.Count)
                        {
                            list.RemoveRange(i + 1, (int)power);
                        }
                        else if (i + power >= list.Count)
                        {
                            list.RemoveRange(i + 1, list.Count - 1 - i);
                        }
                        if (i - power >= 0)
                        {
                            list.RemoveRange(i - (int)power, (int)power + 1);
                        }
                        else if (i - power < 0)
                        {
                            if (list.Count >= power)
                            {
                                list.RemoveRange(0, (int)power);
                            }
                            else
                            {
                                list.RemoveRange(0, list.Count);
                            }
                        }
                        i = 0;
                    }
                }

                decimal sum = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    sum += list[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}