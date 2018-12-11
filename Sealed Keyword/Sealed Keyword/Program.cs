using System;
using Sealed_Keyword.com.Module;

namespace Sealed_Keyword
{
    class Program:ClassA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i'm in class Program");
            ClassA ca = new ClassA();
        }
    }
}
