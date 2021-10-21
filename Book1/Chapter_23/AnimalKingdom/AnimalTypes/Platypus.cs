using System;
using AnimalKingdom.AnimalInterfaces;


namespace AnimalKingdom.AnimalTypes
{
    public class Platypus : IWalking, ISwimming
    {
        public void Walk()
        {
            Console.WriteLine("Walk around");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me!");
        }

        public int MaximumDepth { get; } = 10;

        public void Swim()
        {
            Console.WriteLine("Swim, Swim");
        }
    }
}
