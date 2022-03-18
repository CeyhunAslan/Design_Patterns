using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Example_1.Repositories.Interface
{
    // Memento arayüzü, memento'nun oluşturma tarihi veya adı gibi meta verilerini almanın bir yolunu sağlar. Ancak, Oluşturan'ın durumunu ifşa etmez.
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
