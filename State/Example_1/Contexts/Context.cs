using State.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Example_1.Contexts
{
    // Bağlam, istemcilerin ilgileneceği arayüzü tanımlar. Ayrıca, Context'in mevcut durumunu temsil eden bir State alt sınıfının bir örneğine referansı da korur.
    class Context
    {
        // Bağlamın mevcut durumuna bir referans.
        private State_ _state = null;

        public Context(State_ state)
        {
            this.TransitionTo(state);
        }

        // Context, State nesnesinin çalışma zamanında değiştirilmesine izin verir.
        public void TransitionTo(State_ state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        // Bağlam, davranışının bir kısmını geçerli Durum nesnesine devreder.
        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
