using Builder.Abstract_Builder;
using Builder.Concrete;
using Builder.Director;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            waiter.setPizzaBuilder(hawaiianPizzaBuilder);
            waiter.constructPizza();

            Pizza pizza = waiter.getPizza();

            Console.WriteLine($"{pizza}");
            Console.ReadKey();
        }
    }
}
