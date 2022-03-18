using Proxy.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example_1.Clients
{
    public class Client
    {
        //İstemci kodunun, hem gerçek özneleri hem de vekilleri desteklemek için Konu arabirimi aracılığıyla tüm nesnelerle(hem özneler hem de vekiller) çalışması gerekir.Ancak gerçek hayatta, istemciler çoğunlukla doğrudan gerçek özneleriyle çalışır. Bu durumda, kalıbı daha kolay uygulamak için proxy'nizi gerçek öznenin sınıfından genişletebilirsiniz.
        public void ClientCode(ISubject subject)
        {
            // ...

            subject.Request();

            // ...
        }
    }
}
