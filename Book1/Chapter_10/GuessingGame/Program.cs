using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // string void SecretNumber()
            {
            Console.WriteLine("Can you guess the secret number? Submit your guess below!");
            Console.WriteLine("> ");
            string response = Console.ReadLine();
            int secretNumber = 42;
            int compare = int.Compare(Parse($"{response}"), secretNumber);
            }
        }
    }
}

/*
using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecretNumber()
            {
            Console.WriteLine("Can you guess the secret number? Submit your guess below!");
            Console.WriteLine("> ");
            string response = Console.ReadLine();
            int secretNumber = 42;
            }
            // Console.WriteLine($"You guessed {response}");
            void Compare()
            {
                 
                bool Comparison = SecretNumber()
                if(secretNumber == response);
                {
                    Console.WriteLine("Congrats! You got it right!");
                } 
                else  
                {
                    Console.WriteLine("Wrong Answer.");
                }
            }
        }
    }
}
*/