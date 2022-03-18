using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Example_1.Concrete.Compoment;

namespace Visitor.Example_1.Interface.Visitor
{
    // Visitor İnterface, bileşen sınıflarına karşılık gelen bir dizi ziyaret yöntemi bildirir. Bir ziyaret yönteminin imzası, ziyaretçinin uğraştığı bileşenin tam sınıfını tanımlamasına olanak tanır.
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
