using System;
using Loosly_Couple_Code.com.Module;

namespace Loosly_Couple_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Univercity uni = new Univercity();
            uni.AddDepartment("Himanshu", "Rahul", Dep.art, 123);
            uni.AddDepartment("Rahul", "Himanshu", Dep.comp, 10);

            foreach (var item in uni.department)
            {
                if(item is Art)
                {
                    Art art = (Art)item;
                    Console.WriteLine("Name:{0} Director:{1} Students:{2}", art.Name, art.Director, art.NoStudent);
                }
                else if(item is Computer)
                {
                    Computer comp = (Computer)item;
                    Console.WriteLine("Name:{0} Director:{1} Lab:{2}", comp.Name, comp.Director, comp.NoLab);
                }
            }
        }
    }
}
