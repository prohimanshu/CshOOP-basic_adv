using System;
using OrgClassFolder.com.StudentDBMS;

namespace OrgClassFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sc = new Student();
            sc.Name = "Himanshu";
            sc.Branch = "CSE";
            sc.Roll_No = 141340101012;
            sc.age = 21;

            sc.Run();
        }
    }
}
