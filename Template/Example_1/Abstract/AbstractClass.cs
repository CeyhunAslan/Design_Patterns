using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Example_1.Abstract
{
    // Soyut Sınıf, (genellikle) soyut ilkel işlemlere yapılan çağrılardan oluşan bazı algoritmaların bir iskeletini içeren bir şablon yöntemi tanımlar.
    //
    // Somut alt sınıflar bu işlemleri uygulamalıdır, ancak şablon yönteminin kendisini olduğu gibi bırakmalıdır..
    abstract class AbstractClass
    {
        // Şablon yöntemi, bir algoritmanın iskeletini tanımlar.
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        // Bu işlemlerin zaten uygulamaları var.
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        }

        // Bu işlemler alt sınıflarda uygulanmalıdır.
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // Bunlar "kancalar". Alt sınıflar onları geçersiz kılabilir, ancak kancalar zaten varsayılan (ancak boş) uygulamaya sahip olduğundan zorunlu değildir. Kancalar, algoritmanın bazı önemli yerlerinde ek uzatma noktaları sağlar.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }

}
