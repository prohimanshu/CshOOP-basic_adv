using System;

namespace AutoProperty.com.Module
{
    class StudentC
    {
        private int age;

        public int Age
        {
            get { return age;
            }
            set { if (value > 0)// check the value of user then include the value
                {
                    age = value;
                }
            }
        }

    }
}
