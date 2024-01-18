using System;

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            int numberOfRolls;
            while (!int.TryParse(Console.ReadLine(), out numberOfRolls) || numberOfRolls <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
            }

            DiceRoller roller = new DiceRoller();
            int[] results = roller.RollDice(numberOfRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                int percentage = results[i - 2] * 100 / numberOfRolls; //To get the percentage
                Console.WriteLine(new String('*', percentage));
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
