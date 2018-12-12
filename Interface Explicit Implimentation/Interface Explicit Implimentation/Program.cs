using System;
using Interface_Explicit_Implimentation.com.Module;

namespace Interface_Explicit_Implimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cr = new Car();
            Iclass aclass=cr;
            aclass.Run();

            Iclassa classa = cr;
            classa.Run();
        }
    }
}
