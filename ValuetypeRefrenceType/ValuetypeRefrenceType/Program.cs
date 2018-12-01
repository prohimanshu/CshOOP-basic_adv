using System;

namespace ValuetypeRefrenceType// set of clss
{
    struct Student//a structure is index value type
    {
        public int age;//these are value type stored in stack
        public int marks;//store in stack
    }
    class Program// main class 
    {
        static void Main(string[] a)
        {
            Student sc = new Student();// student object new refrence memory M1 sc and it will store in heap
            sc.age = 10;//stored in M1 memory
            sc.marks = 100;// stored in M1 memory
            Console.WriteLine("the value of age and marks using object sc is ={0} and {1}", (sc.age), (sc.marks));
            Student sc1 = sc;// create new method and all heap memory M2 copy in new refrence sc1
            Console.WriteLine("the value copy in object sc1 and value of age and mark={0} and {1}", (sc1.age), (sc1.marks));
            Console.WriteLine("we change the object sc value age=20 and mark=200");
            Console.WriteLine("before changing the value object sc is age={0} and mark={1}", (sc.age), (sc.marks));
            Console.WriteLine("before changing the value object sc1 is age={0} and mark={1}", (sc1.age), (sc1.marks));
            sc.age = 20;//change in M1 but not change in M2
            sc.marks = 200;//change in M1 But not change in M2
            Console.WriteLine("after changing the value object sc is age={0} and mark={1}", (sc.age), (sc.marks));
            Console.WriteLine("after Changing the value object sc1 is age={0} and mark={1}", (sc1.age), (sc1.marks));
        }
    }

}