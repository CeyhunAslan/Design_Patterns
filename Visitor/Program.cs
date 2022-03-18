﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Example_1;
using Visitor.Example_1.Concrete.Compoment;
using Visitor.Example_1.Concrete.Visitor;
using Visitor.Example_1.Interface.Visitor;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);
        }
    }
}
