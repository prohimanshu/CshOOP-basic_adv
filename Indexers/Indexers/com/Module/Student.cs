using System;

namespace Indexers.com.Module
{
    class Student
    {
        private int[] array = { 1, 2, 3, 4, 5 };
        public int this [int index]
        {
            get//get the value from class program
            {
                if(index>=0 && index < array.Length)
                {
                    return array[index];//return stored value in index

                }
                else
                {
                    return 0;
                }

            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    if (value > 0)
                    {
                        array[index] = value;//include the value in given index
                    }
                    else
                    {
                        Console.WriteLine("invalid value");
                    }
                }
            }
        }

        public int this [int index, int i]//indexer overload
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value + i;
            }
        }
    }
}
