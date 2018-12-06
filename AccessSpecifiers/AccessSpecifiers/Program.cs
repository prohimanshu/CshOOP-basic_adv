using System;
using TestLibrary;
namespace AccessSpecifiers
{
    class Testprivate // test for private keyword
    {
        private int age;

        public void Setage(int a)// sendbox for varification 
        {
            if (a > 0)//age not a zero
            {
                age = a;//include in  private field
            }
            else
            {
                Console.WriteLine("please retype your age:");
            }
            Console.WriteLine("private value of age:{0}", age);
        }
    }
    class Testprotected// test for protected 
    {
        protected int age;

    }
    class Con : Testprotected//extend class in con class
    {
        public void Show(int a)
        {
            age = a;//parss value include in show method
            Console.WriteLine("Protected parss value is:{0}", age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Testprivate tpri = new Testprivate();// object for clss Testprivate
            tpri.Setage(100);//parss value

            Testprotected tprot = new Testprotected();// object for TestProtected class
            Con co = new Con();// con class also with extend 
            co.Show(10);// parss value in con class

            Class1 c1 = new Class1();//object of library test
            c1.age = 10;//name can't access

           
        }
    }
}
