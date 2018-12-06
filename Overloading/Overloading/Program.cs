using System;
using Overloading.com.Module;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Method md = new Method();
            md.Show();
            md.Show(10);
            md.Show(21, "Himanshu");

            Constructor con = new Constructor();
            Constructor con1 = new Constructor(10);
            Constructor con2 = new Constructor(10,"Himanshu");
        }
    }
}
