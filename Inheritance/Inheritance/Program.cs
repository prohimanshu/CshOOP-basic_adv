using System;
using Inheritance.com.Module;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothes clo = new Clothes();
            clo.ID = 1;
            clo.Name = "muflor";
            clo.Prize = 32;
            clo.Color = "Red";
            Console.WriteLine("Access clothes class ID:{0} Name:{1} Prize:{2} Color:{3}", clo.ID, clo.Name, clo.Prize, clo.Color);

            Hardware hw = new Hardware();
            hw.ID = 2;
            hw.Name = "Table";
            hw.Prize = 1000;
            hw.Size = 999;
            Console.WriteLine("Class Hardware ID:{0} Name:{1} Prize:{2} Size:{3}", hw.ID, hw.Name, hw.Prize, hw.Size);

            Food fd = new Food();
            fd.ID = 3;
            fd.Name = "burger";
            fd.Prize = 80;
            Console.WriteLine("Class food ID:{0} Name:{1} Prize:{2} Date:{3}", fd.ID, fd.Name, fd.Prize, fd.Exp);
        }
    }
}
