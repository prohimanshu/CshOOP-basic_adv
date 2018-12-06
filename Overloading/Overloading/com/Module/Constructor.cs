using System;

namespace Overloading.com.Module
{
    class Constructor
    {
        public Constructor()
        {
            Console.WriteLine(" i'm on default constructor");
        }
        public Constructor(int a)
        {
            Console.WriteLine("i'm on single parss constructor a:{0}", a);
        }
        public Constructor(int a, string b)
        {
            Console.WriteLine("my name is {0} and i'm old", b, a);
        }
    }
}
