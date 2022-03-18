using Facade.Example_1.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example_1.Facades
{
    public class Facade_1
    {
       
        
            //Facade sınıfı, bir veya birkaç alt sistemin karmaşık mantığına basit bir arayüz sağlar.Cephe, istemci isteklerini alt sistem içindeki uygun nesnelere devreder. Cephe ayrıca yaşam döngülerini yönetmekten de sorumludur.Tüm bunlar, istemciyi alt sistemin istenmeyen karmaşıklığından korur.
            protected Subsystem1 _subsystem1;

            protected Subsystem2 _subsystem2;

            public Facade_1(Subsystem1 subsystem1, Subsystem2 subsystem2)
            {
                this._subsystem1 = subsystem1;
                this._subsystem2 = subsystem2;
            }

            //Cephe yöntemleri, alt sistemlerin karmaşık işlevlerine uygun kısayollardır.Ancak, istemciler alt sistem yeteneklerinin yalnızca bir kısmına erişir.
            public string Operation()
            {
                string result = "Facade initializes subsystems:\n";
                result += this._subsystem1.operation1();
                result += this._subsystem2.operation1();
                result += "Facade orders subsystems to perform the action:\n";
                result += this._subsystem1.operationN();
                result += this._subsystem2.operationZ();
                return result;
            }
     
    }
}
