using Mediator.Example_1.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Example_1.Entities.Components
{
    // Concrete Bileşenler çeşitli işlevler uygular. Diğer bileşenlere bağlı değildirler. Ayrıca herhangi bir somut arabulucu sınıfına bağlı değildirler.
    class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");

            this._mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");

            this._mediator.Notify(this, "B");
        }
    }
}
