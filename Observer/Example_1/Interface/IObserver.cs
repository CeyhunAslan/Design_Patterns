using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Example_1.Interface
{
    public interface IObserver
    {
        // subjectden güncelleme al
        void Update(ISubject subject);
    }
}
