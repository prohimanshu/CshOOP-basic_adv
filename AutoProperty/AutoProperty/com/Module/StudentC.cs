﻿using System;

namespace AutoProperty.com.Module
{
    class StudentC
    {
        private int age;

        public int Age
        {
            get { return age;
            }
            set { if (value > 0)
                {
                    age = value;
                }
            }
        }

    }
}
