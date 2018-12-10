using System;

namespace Parameter_Contructor_in_Inheritance.com.Module
{
    class ClassA:ClassB
    {
        public ClassA(string n):base(n)// parss the parameter in class b method
        {
            Console.WriteLine("hii {0} you are in class A",n);// non working code n not access but parss in class B
        }
    }
}
