using System;

namespace Classtest
{
    class Classt// main class 
    {
        public string Name;//each field access as public by default working as private 
        public string Branch;//stack type memory
        public double Roll_No;
        public void Run()//public method not a return type
        {
            Console.WriteLine("Name:{0} Branch:{1} Roll_NO:{2}", Name, Branch, Roll_No);// to print pass data
        }
    }
    class Program// main class 
    {
        static void Main(string [] a) 
        {
            Classt ct = new Classt();//object of class Classt and take a refrence type memory
            ct.Name = "Himanshu";//pass string data
            ct.Branch = "CSE";
            ct.Roll_No = 141340101012;
            ct.Run();//call the Classt method  
        }

    }
}