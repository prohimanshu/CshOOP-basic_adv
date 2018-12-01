using System;
using EncapsulationAndSandboxing.com.StudentDBMS;

namespace EncapsulationAndSandboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sc = new Student();
            sc.SetAge(21);
            sc.SetMarks(100);
            sc.SetName("Himanshu");
            sc.Run();
        }
    }
}
