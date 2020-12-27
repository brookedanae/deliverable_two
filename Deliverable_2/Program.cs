using System;
using System.Text;
using StatsdClient;
using FizzWare.NBuilder;

namespace Deliverable_2
{
    class Coin
    {

        static void Main(string[] args)

        // UserInput
        {
            int choice;
            Console.Write("Guess which will have more: heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine();
            if (headsOrTailsGuess.ToLower().Trim() == "heads") {
                choice = 0;
            } else
            {
                choice = 1;
            }
  

            Console.Write("\n" + "How many times shall we flip a coin? ");
            int numberOfFlips = int.Parse(Console.ReadLine());
            


            // Declare variables
            int correctCount = 0;
            int heads = 0;
            int tails = 1;

            Random rand = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                int result = rand.Next(0, 2);

                if (result == 0)
                {
                    Console.WriteLine("Heads!");
                } 
                else 
                {
                    Console.WriteLine("Tails!");
                }
                if (result == choice)
                {
                    correctCount++;
                }
 
            }
            Console.WriteLine("\n" + "Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");

            var percentage = ((double)correctCount / numberOfFlips) * 100;

            Console.WriteLine("That's " + percentage + "%.");

        }
        


    }
}
