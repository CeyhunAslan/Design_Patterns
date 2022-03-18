using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Example_1.Interface.Visitor;

namespace Visitor.Example_1
{
    public class Client
    {
        // İstemci kodu, somut sınıflarını çözmeden herhangi bir öğe kümesi üzerinde ziyaretçi işlemlerini çalıştırabilir. Kabul işlemi, bir çağrıyı ziyaretçi nesnesindeki uygun işleme yönlendirir.
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
