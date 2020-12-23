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
            Console.Write("Guess which will have more: heads or tails? ");
            string headsOrTailsGuess = Console.ReadLine() + "\n";
  

            Console.Write("\n" + "How many times shall we flip a coin? ");
            int numberOfFlips = int.Parse(Console.ReadLine() + "\n");


            // Declare variables
            int correctCount = 0;
            int Heads = 0;
            int Tails = 1;

            Random rand = new Random();

            for (int i = 0; i < numberOfFlips; i++)
            {
                int result = rand.Next(0, 2);

                if (result == 0)
                {
                    Console.WriteLine("Heads!");
                } 
                if (result == 1) 
                {
                    Console.WriteLine("Tails!");
                }
                foreach (int result in headsOrTailsGuess)
                {
                    Console.WriteLine(result + correctCount);
                }





            }
        }
         

            

             // Console.WriteLine("Your guess, " + headsOrTailsGuess + " came up " + correctCount + " time(s).");
             // Console.WriteLine("That's + <percentage here> + ".");

     
    }
}
