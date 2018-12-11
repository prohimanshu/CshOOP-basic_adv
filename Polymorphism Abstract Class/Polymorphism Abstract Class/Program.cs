using System;
using Polymorphism_Abstract_Class.com.Module;

namespace Polymorphism_Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Transformer tcar = new Car();
            tcar.Run();
            Transformer tboat = new Boat();
            tboat.Run();
            tboat= new Helicopter();
            tboat.Run();
        }
    }
}
