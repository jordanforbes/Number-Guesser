using System;

// namespace
namespace NumberGuesser
{
    // main class
    class Program
    {
        // entry point method
        static void Main(string[] args)
        {
            // Set app vars 
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jordan Forbes";

            // Change text color  
            Console.ForegroundColor = ConsoleColor.Green;
            
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset color
            Console.ResetColor();

            // Ask users name 
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Init correct number  
            // int correctNumber = 7;

            // Create a new random object 
            Random random = new Random();
            
            // generate random integer from 1 to 10
            int correctNumber = random.Next(1, 10);

            // Init guess var 
            int guess = 0;

            // ask user for number
            Console.WriteLine("Guess a number betwen 1 and 10");

            //while guess is not correct
            while (guess != correctNumber)
            {
                //Get user input
                string input = Console.ReadLine();

                //Make sure it's a number 
                if (!int.TryParse(input, out guess))
                {
                    // Change text color  
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user to guess a number
                    Console.WriteLine("Please Enter an actual number");

                    // reset color
                    Console.ResetColor();

                    //keep going 
                    continue;

                }

                // cast to int and put in guess 
                guess = Int32.Parse(input);

                // check guess //
                // Match guess to correct number  
                if (guess != correctNumber)
                {
                    // Change text color  
                    Console.ForegroundColor = ConsoleColor.Red;

                    // tell user to try again
                    Console.WriteLine("Wrong Number, please try again");

                    // reset color
                    Console.ResetColor();

                }
            }

            // Output success message //

            // Change text color 
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Tell user it's the right number  
            Console.WriteLine("You are correct!");

            // Reset Text Color 
            Console.ResetColor();
            

        }
    }
}
