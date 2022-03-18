using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Example_1.Concrete.Compoment;
using Visitor.Example_1.Interface.Visitor;

namespace Visitor.Example_1.Concrete.Visitor
{
    // Concrete Visitor, aynı algoritmanın tüm somut bileşen sınıflarıyla çalışabilen çeşitli versiyonlarını uygular.
    //
    // Kompozit ağaç gibi karmaşık bir nesne yapısıyla birlikte kullanırken Ziyaretçi kalıbının en büyük avantajını yaşayabilirsiniz. Bu durumda, ziyaretçinin yöntemlerini yapının çeşitli nesneleri üzerinde yürütürken, algoritmanın bazı ara durumlarını depolamak yararlı olabilir.
    class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
        }
    }
}
