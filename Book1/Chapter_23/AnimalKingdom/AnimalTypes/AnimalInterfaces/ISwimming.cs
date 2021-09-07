using System;

namespace AnimalKingdom.AnimalInterfaces
{
    public interface ISwimming
    {
        int MaximumDepth { get; }
        void Swim();
    }
}