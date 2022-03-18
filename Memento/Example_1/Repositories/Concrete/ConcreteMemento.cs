using Memento.Example_1.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Example_1.Repositories.Concrete
{
    // ConcreteMemento, Oluşturanın durumunu depolamak için altyapıyı içerir.
    class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // Oluşturan, durumunu geri yüklerken bu yöntemi kullanır.
        public string GetState()
        {
            return this._state;
        }

        // Yöntemlerin geri kalanı, Meta verileri görüntülemek için Kapıcı tarafından kullanılır.
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }

}
