using System;



internal class Program
{
    private static void Main(string[] args)
    {
        int sizeField = ushort.Parse(Console.ReadLine());
        int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] commands = Console.ReadLine().Split();

        int[] arr = new int[sizeField];

        //assign "1" to array from indexes input
        for (int i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] >= 0 && indexes[i] < arr.Length)
            {
                arr[indexes[i]] = 1;
            }
        }
        // check if commands are under 100
        byte countCommand = 0;
        // how many times to jump
        int jumps = 0;


        while (commands[0] != "end")
        {
            countCommand++;

            if (int.Parse(commands[0]) >= -2147483647 && int.Parse(commands[0]) <= 2147483647
            && int.Parse(commands[2]) >= -2147483647 && int.Parse(commands[2]) <= 2147483647)
            {

                int index = int.Parse(commands[0]);
                int flyLength = int.Parse(commands[2]);


                if (commands[1] == "right")
                {
                    //if flylength is possitive number ladybug flies right
                    if (flyLength > 0 && index >= 0 && index <= arr.Length - 1)
                    {
                        for (int i = index; i < index + flyLength + jumps; i += flyLength)
                        {


                            if (i >= 0 && i <= arr.Length - 1)
                            {
                                if (arr[i] == 0 && jumps == 0)
                                {
                                    break;
                                }

                                else if (jumps == 0 && arr[i] == 1)
                                {
                                    arr[i] = 0;
                                    jumps += flyLength;
                                }
                                else if (arr[i] == 1 && jumps > 0)
                                {
                                    jumps += flyLength;
                                }
                                else if (arr[i] == 0 && jumps > 0)
                                {
                                    arr[i] = 1;

                                }
                            }
                        }
                        jumps = 0;
                    }
                    // if flylength is negative number ladybug flies left
                    else if (flyLength < 0 && index >= 0 && index <= arr.Length - 1)
                    {
                        for (int i = index - jumps; i >= 0; i -= Math.Abs(flyLength))
                        {
                            if (i >= 0 && i <= arr.Length - 1)
                            {

                                if (arr[i] == 0 && jumps == 0)
                                {
                                    break;
                                }

                                else if (jumps == 0 && arr[i] == 1)
                                {
                                    arr[i] = 0;
                                    jumps += Math.Abs(flyLength);
                                }
                                else if (arr[i] == 1 && jumps > 0)
                                {
                                    jumps += Math.Abs(flyLength);
                                }
                                else if (arr[i] == 0 && jumps > 0)
                                {
                                    arr[i] = 1;

                                }
                            }
                        }
                        jumps = 0;
                    }

                }
                else if (commands[1] == "left")
                {
                    if (flyLength > 0 && index >= 0 && index <= arr.Length - 1)
                    {
                        for (int i = index - jumps; i >= 0; i -= flyLength)
                        {
                            if (i >= 0 && i <= arr.Length - 1)
                            {
                                if (arr[i] == 0 && jumps == 0)
                                {
                                    break;
                                }

                                else if (jumps == 0 && arr[i] == 1)
                                {
                                    arr[i] = 0;
                                    jumps += flyLength;
                                }
                                else if (arr[i] == 1 && jumps > 0)
                                {
                                    jumps += flyLength;
                                }
                                else if (arr[i] == 0 && jumps > 0)
                                {
                                    arr[i] = 1;

                                }
                            }
                        }
                        jumps = 0;
                    }
                    else if (flyLength < 0 && index >= 0 && index <= arr.Length - 1)
                    {
                        for (int i = index; i < index + Math.Abs(flyLength) + jumps; i += Math.Abs(flyLength))
                        {


                            if (i >= 0 && i <= arr.Length - 1)
                            {

                                if (arr[i] == 0 && jumps == 0)
                                {
                                    break;
                                }

                                else if (jumps == 0 && arr[i] == 1)
                                {
                                    arr[i] = 0;
                                    jumps += Math.Abs(flyLength);
                                }
                                else if (arr[i] == 1 && jumps > 0)
                                {
                                    jumps += Math.Abs(flyLength);
                                    continue;
                                }
                                else if (arr[i] == 0 && jumps > 0)
                                {
                                    arr[i] = 1;

                                }
                            }
                        }
                        jumps = 0;
                    }
                }

                commands = Console.ReadLine().Split();
            }
        }

        Console.WriteLine(string.Join(" ", arr));
    }
}
