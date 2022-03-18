using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Example_1.Abstract;

namespace Template.Example_1
{
    class Client
    {
        // İstemci kodu, algoritmayı yürütmek için şablon yöntemini çağırır. İstemci kodunun, temel sınıflarının arabirimi aracılığıyla nesnelerle çalıştığı sürece, birlikte çalıştığı bir nesnenin somut sınıfını bilmesi gerekmez.
        public static void ClientCode(AbstractClass abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }
}
