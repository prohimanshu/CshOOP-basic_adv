using System;
using Polymorphism_Interface.com.Module.Interface;
using Polymorphism_Interface.com.Module;

namespace Polymorphism_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransformer ITran = new Car();
            ITran.Run();
            ITran = new Boat();
            ITran.Run();
            ITran = new Helicopter();
            ITran.Run();
        }
    }
}
