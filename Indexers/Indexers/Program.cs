using System;
using Indexers.com.Module;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std[0] = 2100;
            Console.WriteLine("indexer value and value is {0}",std[0]);
            std[0, 1]=10;
            Console.WriteLine("indexer overload object and stored value is {0}",std[0]);
        }
    }
}
