using Decorator.Example_1.Clients;
using Decorator.Example_1.Concrete;
using Decorator.Example_1.Decarators;
using Decorator.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            IBilesen bilesen = new Bilesen();

            Client.Display("Ham hali: ", bilesen);
            Client.Display("Dekorator 1: ", new Decorator_A(bilesen));
            Client.Display("Dekorator 2: ", new Decorator_B(bilesen));
            Client.Display("Kombo Dekorasyon: ", new Decorator_A(new Decorator_B(bilesen)));

            #endregion

            Console.ReadKey();
        }
    }
}
