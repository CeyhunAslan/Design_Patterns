using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Example_1.Interface.Visitor;

namespace Visitor.Example_1.Concrete.Compoment
{
    // Her Somut Bileşen, 'Kabul Et' yöntemini, bileşenin sınıfına karşılık gelen ziyaretçi yöntemini çağıracak şekilde uygulamalıdır.
    public class ConcreteComponentA : IComponent
    {
        // Geçerli sınıf adıyla eşleşen 'Visit Concrete ComponentA'i çağırdığımızı unutmayın. Bu şekilde ziyaretçinin birlikte çalıştığı bileşenin sınıfını bilmesini sağlarız.
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        // Somut Bileşenler, temel sınıflarında veya arabirimlerinde bulunmayan özel yöntemlere sahip olabilir. Ziyaretçi, bileşenin somut sınıfının farkında olduğu için bu yöntemleri kullanmaya devam edebilir.
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
