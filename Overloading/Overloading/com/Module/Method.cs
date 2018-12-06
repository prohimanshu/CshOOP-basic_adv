using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading.com.Module
{
    class Method
    {
        public void Show()
        {
            Console.WriteLine("i'm on show method");
        }
        public void Show(int a)
        {
            Console.WriteLine("method show and value a:{0}", a);
        }
        public void Show(int a, string b)
        {
            Console.WriteLine("my name is {0} and age is {1}", b, a);
        }
    }
}
