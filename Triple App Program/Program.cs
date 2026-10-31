using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project_Unknown_for_now_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dear Customer!");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Rock Paper Scissors");
            Console.WriteLine("3. Number guessing game");
            

            switch (Console.ReadLine())
            {
                case "Calculator":
                    Calculator();
                    break;
                case "Rock Paper Scissors":
                    RockPaperScissors();
                    break;
                case "Number guessing game":
                    NumberGuessingGame();
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;
            }
        }
        static void Calculator()
        {
            
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Please enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();
            double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operation, please try again.");
                        break;
                }
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Would you like to perform another calculation? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Calculator();
            }
            else
            {
                Console.WriteLine("Thank you for using the calculator!");
            }
        }
        static void RockPaperScissors()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Please enter your choice (rock, paper, scissors):");
            string userChoice = Console.ReadLine().ToLower();
            Random rand = new Random();
            int computerChoice = rand.Next(1, 4);
            string computerChoiceString = "";
            switch (computerChoice)
            {
                case 1:
                    computerChoiceString = "rock";
                    break;
                case 2:
                    computerChoiceString = "paper";
                    break;
                case 3:
                    computerChoiceString = "scissors";
                    break;
            }
            Console.WriteLine("The computer chose: " + computerChoiceString);
            if (userChoice == computerChoiceString)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == "rock" && computerChoiceString == "scissors" || userChoice == "paper" && computerChoiceString == "rock" || userChoice == "scissors" && computerChoiceString == "paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.WriteLine("Would you like to play again? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                RockPaperScissors();
            }
            else
            {
                Console.WriteLine("Thank you for playing Rock Paper Scissors!");
            }
        }
        static void NumberGuessingGame()
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Random rand = new Random();
            int numberToGuess = rand.Next(1, 101);
            int numberOfTries = 0;
            int userGuess = 0;
            while (userGuess != numberToGuess)
            {
                Console.WriteLine("Please enter your guess (between 1 and 100):");
                userGuess = Convert.ToInt32(Console.ReadLine());
                numberOfTries++;
                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number in " + numberOfTries + " tries.");
                    Console.WriteLine("Would you like to play again? (yes/no)");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        NumberGuessingGame();
                    }
                    else
                    {
                        Console.WriteLine("Thank you for playing the Number guessing game!");
                    }
                }
            }
        }
    }
}
