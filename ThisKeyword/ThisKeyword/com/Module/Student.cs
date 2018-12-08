using System;

namespace ThisKeyword.com.Module
{
    class Student
    {
        private int age;
        private string name;
        public void setvalue(int age,string name)
        {
            this.age = age;
            this.name = name;
            Console.WriteLine("parss age is {0}", this.age);//access private value age
            Console.WriteLine("parss name is {0}", this.name);// access private value name
        }
        
    }
}
