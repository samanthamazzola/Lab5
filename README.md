# Lab5

using System;

namespace Lab5
{
    class MainClass
    {
        public static bool userChoice = true;

        static void Main(string[] args)
        {
            long i;
            long inputNum;
            long factorial;

            //prompt
            Console.WriteLine("Welcome to the Factorial Calculator!");


            while (toCalculate)
            {

                //input
                Console.WriteLine("Please enter an integer that is greater than 0, but less than 10:");
                string inputNum = Console.ReadLine();

                if (int.TryParse(inputNum, out int j))

                {
                    int number = int.Parse(inputNum);

                    if (inputNum > 0 && inputNum < 10)
                    {
                        long factorial = Findfactorial(inputNum);
                        Console.WriteLine("The factorial of " + inputNum + " is: " + factorial);
                    }
                    else
                    {
                        Console.WriteLine("Number must be greater than 0 but less than 10");

                    }
                }
            }
            else
            {
                Console.WriteLine("Please write a number.");
            }
                Restart();
            }

            Console.ReadKey();

        //find the factorial calulation
            public static long Findfactorial(int inputNum)
            {
                if (inputNum == 0)

                    return 1;
                {
                    long factorial = 1;

                    for (i = inputNum - 1; i >= 1; i--)
                    {

                        factorial = factorial * i;
                    }

                    return factorial;
                }
                // validate based on y or n
                public static void toCalculate() 
                {
                    Console.WriteLine("Would you like to continue? Enter y/n:");

                    var userInput = Console.ReadKey().KeyChar;

                    if (userInput != "y")
                    {
                        toCalculate = false;
                        Console.WriteLine("Thank you for using the Factorial Calculator!");
                    }
                }
            }
        }
    }
}

