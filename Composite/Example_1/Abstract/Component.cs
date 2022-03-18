using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example_1.Abstract
{
    abstract class Component
    {
        //Temel Bileşen sınıfı, bir bileşimin hem basit hem de karmaşık nesneleri için ortak işlemleri bildirir.
        public Component() { }

        //Temel Bileşen, bazı varsayılan davranışları uygulayabilir veya bunu somut sınıflara bırakabilir(davranışı içeren yöntemi "soyut" olarak bildirerek).
        public abstract string Operation();
        //Bazı durumlarda, alt-yönetim işlemlerini doğrudan temel Bileşen sınıfında tanımlamak faydalı olabilir.Bu şekilde, nesne ağacı montajı sırasında bile herhangi bir somut bileşen sınıfını istemci koduna maruz bırakmanız gerekmez.Dezavantajı, bu yöntemlerin yaprak seviyesindeki bileşenler için boş olmasıdır.
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        //İstemci kodunun bir bileşenin alt öğeleri taşıyıp taşımayacağını anlamasını sağlayan bir yöntem sağlayabilirsiniz.
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
