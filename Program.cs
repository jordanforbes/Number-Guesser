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
            GetAppInfo(); //print app info

            GreetUser(); //ask for users name and greet

            while (true)
            {

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
                        // Tell user to guess a number
                        // reset color         
                        PrintColorMessage(ConsoleColor.Red, "Please Enter an actual number");

                        //keep going 
                        continue;

                    }

                    // cast to int and put in guess 
                    guess = Int32.Parse(input);

                    // check guess //
                    // Match guess to correct number  
                    if (guess != correctNumber)
                    {
                        //change text color, tell user they put in the wrong number, reset text color
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");

                    }
                }

                // Output success message //
                PrintColorMessage(ConsoleColor.Yellow, "YOU ARE CORRECT!!!");
                

                // Ask to play again 
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer 
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // get and display app info
        static void GetAppInfo()
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
        }


        //ask users name and greet
        static void GreetUser()
        {
            // Ask users name 
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color,string message)
        {
            // Change text color 
            Console.ForegroundColor = color;

            //Tell user it's the right number  
            Console.WriteLine(message);

            // Reset Text Color 
            Console.ResetColor();
        }
    }
}
