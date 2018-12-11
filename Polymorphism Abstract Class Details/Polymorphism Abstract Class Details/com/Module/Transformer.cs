using System;

namespace Polymorphism_Abstract_Class_Details.com.Module
{
    abstract class Transformer
    {
        public void Show()
        {
            Console.WriteLine("i'm in transformer Show method");
        }
        public Transformer()
        {
            Console.WriteLine("i'm in transformer constroctor");
        }
        public abstract void Run();
    }
}
