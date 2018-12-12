using System;

namespace Interface_Explicit_Implimentation.com.Module
{
    interface Iclass
    {
        void Run();
    }
    interface Iclassa
    {
        void Run();
    }
    class Car : Iclass, Iclassa
    {
        void Iclass.Run()
        {
            Console.WriteLine("run Iclass");
        }

        void Iclassa.Run()
        {
            Console.WriteLine("run Iclassa");
        }
    }
}
