using System;
using AnimalKingdom.AnimalInterfaces;


namespace AnimalKingdom.AnimalTypes
{
    public class Cat : IWalking
    {
        public void Walk()
        {
            Console.WriteLine("Walk around");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me!");
        }
    }

}