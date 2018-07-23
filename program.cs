using System;

namespace Lab5
{
    class MainClass
    {
        public static bool userChoice = true;

        static void Main(string[] args)
        {
           
            long inputNum;
            string userChoice = "y";

            //prompt
            Console.WriteLine("Welcome to the Factorial Calculator!");

            // while condition is y
            while (userChoice.ToLower()=="y")
            {

                //input
                Console.WriteLine("Please enter an integer that is greater than 0, but less than 10:");
                string input = Console.ReadLine();

                // if valid input
                if (input.Length == 0) 
                    continue;
                inputNum = long.Parse(input);

                // if invalid input
                if (inputNum >= 10 || inputNum < 1)
                {
                    Console.WriteLine("Sorry! That's an invalid input!");
                    continue;
                }

                // for loop 
                long factorial = 1;
                for (long i = inputNum; i > 0; i --)
                {
                    factorial = factorial * i;
                }

                // output
                Console.WriteLine("The factorial of " + inputNum + " is: " + factorial);


                // validation prompt
                Console.WriteLine("Would you like to continue? Enter y/n:");

                userChoice = Console.ReadLine();

             }
         }
     }
 }
