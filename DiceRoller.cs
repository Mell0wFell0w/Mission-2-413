using System;

namespace DiceRollingSimulator
{
    public class DiceRoller
    {
        private Random random = new Random();

        public int[] RollDice(int numberOfRolls)
        {
            int[] results = new int[11]; // For storing counts of sums 2-12

            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollOne = random.Next(1, 7);
                int rollTwo = random.Next(1, 7);
                int sum = rollOne + rollTwo;
                results[sum - 2]++;
            }

            return results;
        }
    }
}
