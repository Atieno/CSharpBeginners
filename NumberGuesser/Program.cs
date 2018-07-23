using System;
using System.Linq;


//Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {

        //Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo(); // Run GetAppInfo function to get Info

            GreetUser();// Ask for user name and Greet

            //Ask Users Name
            Console.WriteLine("What is your name:");

            //Get User input
            string inputName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputName))
                throw new ArgumentException("Name must contain a value");
            if (inputName.Length > 40)
                throw new ArgumentException("The Name is too long to be accepted");
            if (inputName.Any(c => char.IsDigit(c)))
                throw new ArgumentException("Name cannot Accept intergers");

            Console.WriteLine("Hello {0}, let's Play a game...", inputName );

            while (true)
            {

            //Create a random object
            Random random = new Random();

            int correctNumber = random.Next(1,10);

            //init guess var 

            int guess = 0;

            //Ask user for the number 
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while (guess != correctNumber)
            {
                //Get users input
                string input = Console.ReadLine();

                //Make sure Its a number 
                if (!int.TryParse(input, out guess) )
                {

                        //print error message
                        PrintColorMassage(ConsoleColor.Red, "Please use an actual number");
                    //Keep going 
                    continue;

                }


                //cast to int and put into guess
                guess = Int32.Parse(input);

                //match guess to correct number 
                if(guess != correctNumber)
                {
                        //Print error message
                        PrintColorMassage(ConsoleColor.Red, "Wrong Number, Please try again!!");

                    }

            }

                //Print Success message
                PrintColorMassage(ConsoleColor.Yellow, "You are CORRECT!!!");


                //Ask to play again
                Console.WriteLine("Play Again[Y or N]");

                //Get Answer 
                string answer=Console.ReadLine().ToUpper();

                if (answer=="Y")
                {
                    continue;

                }
                else if (answer=="N"){
                    return;
                }

            }


        }
        //Get and Display App Info 
        static void GetAppInfo()
        {

            //Ser App Vers
            string appName = "Number Geuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dan Kochillo";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Write out app Infor=

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset Color
            Console.ResetColor();

        }

        //Ask User's name and greet 
        static void GreetUser()
        {

            //Ser App Vers
            string appName = "Number Geuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dan Kochillo";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            //Write out app Infor=

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            //Reset Color
            Console.ResetColor();
        }
        //Print color mesage
        static void PrintColorMassage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color; //which comes from the 1st arg


            //Tell User its the right number

            Console.WriteLine(message);//comes from the 2nd argument
            //Reset Color
            Console.ResetColor();

        }
    }
}
