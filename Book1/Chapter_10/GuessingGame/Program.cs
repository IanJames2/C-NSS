using System;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            Console.WriteLine("Can you guess the secret number? Submit your guess below!");
            Console.WriteLine("> ");
            string response = Console.ReadLine();
            var secretNumber = "42";
            if (response == secretNumber) 
            {
                Console.WriteLine("Correct!");
            }
            else 
            {
                Console.WriteLine("Wrong!");
            }
            }
        }
    }
}

//Sad
