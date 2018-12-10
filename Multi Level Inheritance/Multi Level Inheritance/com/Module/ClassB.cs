using System;

namespace Multi_Level_Inheritance.com.Module
{
    class ClassB:ClassC
    {
        public ClassB()
        {
            this.ID = 20;
            Console.WriteLine("i'm in class B ID:{0}",ID);
        }
    }
}
