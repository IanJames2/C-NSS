using System;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose difficulty level: Easy --> 1; Medium --> 2; Hard --> 3; Cheater --> 4");
            Console.WriteLine("> ");
            var difficulty = int.Parse(Console.ReadLine());
            var infinity =  int.MaxValue;
            for (var i = new int[] { 8, 6, 4, infinity }[difficulty - 1]; i > 0; i--)
            {
            Console.WriteLine("Can you guess the secret number? Submit your guess below!");
            Random random = new System.Random(); 
            var secretNumber = random.Next(1, 100);
            string response = Console.ReadLine();
            if (int.Parse(response) == secretNumber) 
            {
                Console.WriteLine("Correct!");
                Console.WriteLine($"{i} guesses remaining");
                break;
            }
            else if (int.Parse(response) > secretNumber)
            {
                Console.WriteLine("Wrong! You're too high");
                Console.WriteLine($"{i} guesses remaining");
            }
            else 
            {
                Console.WriteLine("Wrong! You're too low");
                Console.WriteLine($"{i} guesses remaining");
            }
            }
        }
    }
}

//Sad
