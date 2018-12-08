using System;

namespace AutoProperty.com.Module
{
    class StudentB
    {
        public int Age { get; private set; }
        public StudentB(int a)
        {
            Age = a;
            //outher class can't change the value of Age
        }
    }
}
