using Composite.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example_1.Client
{
    class Client
    {
        // İstemci kodu, temel arabirim aracılığıyla tüm bileşenlerle çalışır.
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"RESULT: {leaf.Operation()}\n");
        }

        // Alt-yönetim işlemlerinin temel Bileşen sınıfında bildirilmesi sayesinde, istemci kodu, somut sınıflarına bağlı olmaksızın basit veya karmaşık herhangi bir bileşenle çalışabilir.
        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
