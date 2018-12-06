using System;

namespace Overloading.com.Module
{
    class Mix
    {
        private double age;
        private string name;
        public Mix(int a, string b)
        {
            age = a;
            name = b;
        }
        public void Show()
        {
            Console.WriteLine("name is:{0} and age is:{1}",name,age);
        }
    }
}
