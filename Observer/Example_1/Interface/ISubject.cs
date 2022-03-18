using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Example_1.Interface
{
    public interface ISubject
    {
        //subject bir gözlemci(Observer) ekleyin. 
        void Attach(IObserver observer);

        // subject bir gözlemci ayırın.
        void Detach(IObserver observer);

        // Tüm gözlemcileri bir olay hakkında bilgilendirin.
        void Notify();
    }

}
