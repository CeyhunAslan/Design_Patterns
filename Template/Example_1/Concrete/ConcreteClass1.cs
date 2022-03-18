using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Example_1.Abstract;

namespace Template.Example_1.Concrete
{
    // Somut sınıflar, temel sınıfın tüm soyut işlemlerini uygulamak zorundadır. Ayrıca, varsayılan bir uygulama ile bazı işlemleri geçersiz kılabilirler.
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }
}
