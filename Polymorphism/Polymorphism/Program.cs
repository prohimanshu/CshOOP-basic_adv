using System;
using Polymorphism.com.Module;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer tcar = new Car();
            tcar.Run();
            Transformer theli = new Helicopter();
            theli.Run();
            Transformer tboat = new Boat();
            tboat.Run();
        }
    }
}
