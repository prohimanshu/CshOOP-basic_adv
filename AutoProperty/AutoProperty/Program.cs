using System;
using AutoProperty.com.Module;

namespace AutoProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auto property
            StudentA sa = new StudentA();
            sa.Age = 10;
            Console.WriteLine("Auto Property Age is {0}", (sa.Age));

            //outer property
            StudentB sb = new StudentB(20);
            Console.WriteLine("Outer Property Age is {0}", (sb.Age));

            //full property
            StudentC sc = new StudentC();
            sc.Age = 30;
            Console.WriteLine("Full Property Age is {0}", sc.Age);

        }
    }
}
