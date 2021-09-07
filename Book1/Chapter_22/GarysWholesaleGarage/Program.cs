using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram1500 = new Ram();

            fxs.Drive();
            fxs.Turn("north");
            fxs.Stop();
            Console.WriteLine("  ");
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine("  ");
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            Console.WriteLine("  ");
            ram1500.Drive();
            ram1500.Turn("west");
            ram1500.Stop();
            Console.WriteLine("  ");
        }
    }
}
