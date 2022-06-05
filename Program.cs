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
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }
    }
}
