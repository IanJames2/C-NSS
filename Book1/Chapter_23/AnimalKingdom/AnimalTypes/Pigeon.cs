using System;
using AnimalKingdom.AnimalInterfaces;


namespace AnimalKingdom.AnimalTypes
{
    public class Pigeon : IFlying, IWalking
    {
        public void Walk()
        {
            Console.WriteLine("Walk around");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me!");
        }

        public void Fly()
        {
            Console.WriteLine("I'm in the air!");
        }
    }

}