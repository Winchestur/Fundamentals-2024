using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        if (array.Length % 4 == 0)
        {

            int[] leftSide = new int[array.Length / 4];
            int[] rightSide = new int[array.Length / 4];

            int[] newArr = new int[array.Length / 2];

            int[] middle = new int[array.Length / 2];

            int counter = 0;

            // take leftSide numbers from array

            for (int i = 0; i < array.Length / 4; i++)
            {
                leftSide[i] = array[i];
            }

            // reverse leftSide
            for (int i = 0; i < leftSide.Length - leftSide.Length / 2; i++)
            {
                int lastNum = leftSide[leftSide.Length - 1 - i];
                int firstNum = leftSide[i];
                leftSide[i] = lastNum;
                leftSide[leftSide.Length - 1 - i] = firstNum;
            }

            // take rightSide numbers from reversed array"
            for (int i = array.Length - 1; i >= array.Length - array.Length / 4; i--)
            {
                rightSide[counter] = array[i];
                counter++;
            }
            counter = 0;

            // put left and right side in one new arr 

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < array.Length / 4)
                {
                    newArr[i] = leftSide[i];
                }
                else
                {
                    newArr[i] = rightSide[counter];
                    counter++;
                }
            }
            counter = 0;

            //take middle array
            for (int i = array.Length / 4; i < array.Length - array.Length / 4; i++)
            {
                middle[counter] = array[i];
                counter++;
            }
            counter = 0;



            array = new int[middle.Length];
            // sum middle with newArr 
            for (int i = 0; i < middle.Length; i++)
            {
                array[i] = middle[i] + newArr[i];
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}


