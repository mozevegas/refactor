using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class Program
    {
        // my machine   
        static int MyFirstFunction()
        {
            var newRanNum = new Random().Next(1, 101);
            return newRanNum;
        }

        static void MySecondFunction(string bucket)
        {
            if (bucket == "hello")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("not correct");
            }
        }

        static int ParseChecker(string checkMe)
        {
            int guessFunction = 0;
            int.TryParse(checkMe, out guessFunction);
            return guessFunction;
        }

        static void Main(string[] args)
        {
            // Creates the random number
            // var ranNum = new Random().Next(1, 101);
            //Console.WriteLine($"the target is {ranNum}");
            var ranNum = MyFirstFunction();
            Console.WriteLine($"This is success {ranNum}");

            Console.WriteLine("Enter hello");
            MySecondFunction(Console.ReadLine());

            // var newTwo = MySecondFunction();
            // Console.WriteLine($"you said {newTwo}");
            


            // creates a counter as an integer
            var countsTrys = 0;

            // creates a container for guesses
            var guess = 0;

            // creates an array to store the guesses with 5 values
            var pastGuess = new int[5];

            // starts loop of asking for inputted questions
            while (countsTrys < 5 && guess != ranNum)


            {

                // asks for guess and checks number -- METHOD
                Console.WriteLine("I'm thinking of a number 1-100. What is it?");
                ParseChecker(Console.ReadLine());
                // var input = Console.ReadLine();
                // int.TryParse(input, out guess);

                // creates boolean for checking if number was guessed before
                var wasAlreadyGuess = false;

                // searches through the array for comparing
                foreach (var userGuess in pastGuess)
                {
                    if (guess == userGuess)
                    {
                        wasAlreadyGuess = true;
                    }
                }

                // if this loop true, prints out message that guess repeats

                if (wasAlreadyGuess)
                {
                    Console.WriteLine("You aalready guesses that, foool");
                }
                // not true it shows regular result of too high too low
                else
                {
                    pastGuess[countsTrys] = guess;

                    Console.WriteLine($"your guess was {guess}");

                    if (guess < ranNum)
                    {
                        Console.WriteLine("Too low, try again.");
                    }
                    else if (guess > ranNum)
                    {
                        Console.WriteLine("Too high, try again");
                    }

                    Console.WriteLine("Your past guesses are:");
                }
                // cycles through array and shows all past guesses
                foreach (var userGuess in pastGuess)
                {
                    if (userGuess != 0)
                    {
                        Console.Write($"{userGuess},");
                    }
                }

                // adds to counter, once reaches 5 it breaks out of cycle 
                countsTrys++;
            }

            
            // out of the main loop and evaluates whether counter broke free or not
            if (countsTrys > 4)
            {
                Console.WriteLine("You lost :-(");
            }
            else
            {
                Console.WriteLine("You Won!");
            }



        }
    }
}
