using System;

namespace Multi_Level_Inheritance.com.Module
{
    class ClassA:ClassB
    {
        public ClassA()
        {
            this.ID = 30;
            Console.WriteLine("I'm on class A ID:{0}",ID);
        }
    }
}
