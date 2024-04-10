internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();

        getMax(type);
    }

    private static void getMax(string type)
    {
        if (type == "int")
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int result = Math.Max(numOne, numTwo);

            Console.WriteLine(result);
        }
        else if (type == "char")
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());

            if (charOne > charTwo)
            {
                Console.WriteLine(charOne);
            }
            else if (charTwo >= charOne)
            {
                Console.WriteLine(charTwo);
            }
        }
        else if (type == "string")
        {
            string strOne = Console.ReadLine();
            string strTwo = Console.ReadLine();

            if (strOne.CompareTo(strTwo) > 0)
            {
                Console.WriteLine(strOne);
            }
            else
            {
                Console.WriteLine(strTwo);
            }
        }
    }
}