﻿using System;
using Polymorphism_Interface.com.Module.Interface;

namespace Polymorphism_Interface.com.Module
{
    class Helicopter : ITransformer
    {
        public void Run()
        {
            Console.WriteLine("Run Helicopter");
        }
    }
}
