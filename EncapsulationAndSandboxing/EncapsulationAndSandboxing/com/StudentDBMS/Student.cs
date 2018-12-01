using System;

namespace EncapsulationAndSandboxing.com.StudentDBMS
{
    class Student
    {
        private string Name;
        private int Age;
        private int Marks;

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Please do't empty string");
            }
        }
        public void SetAge(int age)
        {
            if (age != 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("invalid age");
            }
        }
        public void SetMarks(int marks)
        {
            if (marks<=100)
            {
                Marks = marks;
            }
            else
            {
                Console.WriteLine("invalid marks");
            }
        }
        public void Run()
        {
            Console.WriteLine("valid data is Name:{0} Age:{1} Marks:{2}",Name,Age,Marks);
        }
    }
}
