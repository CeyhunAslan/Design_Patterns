using Strategy.Example_1.Concrete;
using Strategy.Example_1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // İstemci kodu somut bir strateji seçer ve onu bağlama iletir. Müşteri, doğru seçimi yapabilmek için stratejiler arasındaki farkların farkında olmalıdır.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadKey();
        }
    }
}
