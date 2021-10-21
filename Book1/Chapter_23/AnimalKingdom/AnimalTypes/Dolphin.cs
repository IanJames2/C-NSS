using System;
using AnimalKingdom.AnimalInterfaces;


namespace AnimalKingdom.AnimalTypes
{
    public class Dolphin : ISwimming
    {
        public int MaximumDepth { get; } = 1000;

        public void Swim()
        {
            Console.WriteLine("Swim, Swim");
        }
    }

}