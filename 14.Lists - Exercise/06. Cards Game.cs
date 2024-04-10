

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            int takeWinningCard = 0;
            int takeLossingCard = 0;
            int sum = 0;

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                if (playerOne[0] == playerTwo[0])
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                else if (playerOne[0] > playerTwo[0])
                {
                    takeWinningCard = playerOne[0];
                    takeLossingCard = playerTwo[0];
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                    playerOne.Add(takeLossingCard);
                    playerOne.Add(takeWinningCard);
                }
                else if (playerOne[0] < playerTwo[0])
                {
                    takeLossingCard = playerOne[0];
                    takeWinningCard = playerTwo[0];
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                    playerTwo.Add(takeLossingCard);
                    playerTwo.Add(takeWinningCard);
                }
            }

            if (playerOne.Count > playerTwo.Count)
            {
                for (int i = 0; i < playerOne.Count; i++)
                {
                    sum += playerOne[i];
                }

                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                for (int i = 0; i < playerTwo.Count; i++)
                {
                    sum += playerTwo[i];
                }

                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
