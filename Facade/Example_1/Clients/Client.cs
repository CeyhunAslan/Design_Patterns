using Facade.Example_1.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example_1.Clients
{
    public class Client
    {
        //İstemci kodu, Cephe tarafından sağlanan basit bir arayüz aracılığıyla karmaşık alt sistemlerle çalışır.Bir cephe alt sistemin yaşam döngüsünü yönettiğinde, müşteri alt sistemin varlığından bile haberdar olmayabilir.Bu yaklaşım, karmaşıklığı kontrol altında tutmanızı sağlar.
        public static void ClientCode(Facade_1 facade)
        {
            Console.Write(facade.Operation());
        }

    }
}
