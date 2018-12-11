using System;
using Polymorphism_Abstract_Class_Details.com.Module;

namespace Polymorphism_Abstract_Class_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer tcar = new Car();
            tcar.Show();
            tcar.Run();// call car
        }
    }
}
