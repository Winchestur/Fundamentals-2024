using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 0;

        int[] arr = { 1 };
        Console.WriteLine(string.Join(" ", arr));
        int[] newArr = new int[arr.Length + 1];
        int count = 0;

        while (n - 1 > counter)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    newArr[count] = arr[i] + 0;
                    count++;
                }
                if (i > 0 && i < arr.Length)
                {
                    newArr[count] = arr[i - 1] + arr[i];
                    count++;
                }

                if (i == arr.Length - 1)
                {
                    if (arr.Length - 1 == i)
                    {
                        newArr[count] = arr[i];
                        count++;
                    }
                    else
                    {
                        newArr[count] = arr[i - 1];
                        count++;
                    }
                }
            }

            arr = new int[newArr.Length];

            for (int i = 0; i < newArr.Length; i++)
            {
                arr[i] = newArr[i];
            }

            newArr = new int[arr.Length + 1];
            Console.WriteLine(string.Join(" ", arr));
            count = 0;
            counter++;
        }
    }
}