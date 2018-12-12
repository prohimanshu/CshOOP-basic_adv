using System;
using Composition.com.Module;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Univercity uni = new Univercity();
            uni.IniArt("Himanshu", 321, "Rahul");
            uni.IniComp("Rahul", 10, "Himanshu");
            Console.WriteLine("Name:{0} Student:{1} Director:{2}",(uni.Ar.Name),(uni.Ar.NoStudent),(uni.Ar.Director));
            Console.WriteLine("Name:{0} Lab:{1} Director:{2}", (uni.Comp.Name), (uni.Comp.NoLab), uni.Comp.Director);
        }
    }
}
