﻿using State.Example_1.Concrete;
using State.Example_1.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
                // The client code.
                var context = new Context(new ConcreteStateA());
                context.Request1();
                context.Request2();


                Console.ReadKey();
        }
    }
}
