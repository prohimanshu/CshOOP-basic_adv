using System;
using Polymorphism_Interface.com.Module.Interface;

namespace Polymorphism_Interface.com.Module
{
    class Car : ITransformer
    {
        public void Run()
        {
            Console.WriteLine("Run Car");
        }
    }
}
