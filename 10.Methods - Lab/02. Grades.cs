internal class Program
{
    private static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());

        if (grade >= 2 && grade <= 2.99)
        {
            fail(grade);
        }
        else if (grade >= 3 && grade <= 3.49)
        {
            poor(grade);
        }
        else if (grade >= 3.50 && grade <= 4.49)
        {
            good(grade);
        }
        else if (grade >= 4.50 && grade <= 5.49)
        {
            veryGood(grade);
        }
        else if (grade >= 5.50 && grade <= 6)
        {
            excellent(grade);
        }
    }

    private static void excellent(double grade)
    {
        Console.WriteLine($"Excellent");
    }

    private static void veryGood(double grade)
    {
        Console.WriteLine($"Very good");
    }

    private static void good(double grade)
    {
        Console.WriteLine($"Good");
    }

    private static void poor(double grade)
    {
        Console.WriteLine($"Poor");
    }

    private static void fail(double grade)
    {
        Console.WriteLine($"Fail");
    }
}