using System;

namespace OrgClassFolder.com.StudentDBMS
{//-------project name---folder-- modulename
    class Student
    {
        public string Name;
        public string Branch;
        public double Roll_No;
        public int age;
        public void Run()
        {
            Console.WriteLine("i'm in class student");
            Console.WriteLine("Name: {0}\nBranch: {1}\nRoll_No: {2}\nAge: {3}", Name, Branch, Roll_No, age);
        }
    }
}
