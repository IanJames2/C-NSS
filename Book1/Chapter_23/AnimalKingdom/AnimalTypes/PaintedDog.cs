using System;
using AnimalKingdom.AnimalInterfaces;

namespace AnimalKingdom.AnimalTypes
{
    public class PaintedDog : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }

}