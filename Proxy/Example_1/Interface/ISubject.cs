using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example_1.Interface
{
    //Konu arabirimi, hem RealSubject hem de Proxy için ortak işlemleri bildirir.İstemci bu arabirimi kullanarak RealSubject ile çalıştığı sürece, onu gerçek bir konu yerine bir proxy'ye iletebileceksiniz.
    public interface ISubject
    {
        void Request();
    }
}
