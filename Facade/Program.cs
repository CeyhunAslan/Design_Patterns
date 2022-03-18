using Facade.Example_1.Clients;
using Facade.Example_1.Facades;
using Facade.Example_1.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //İstemci kodu, önceden oluşturulmuş bazı alt sistem nesnelerine sahip olabilir.Bu durumda, Cephe'nin yeni örnekler oluşturmasına izin vermek yerine Cephe'yi bu nesnelerle başlatmak faydalı olabilir.


            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade_1 facade = new Facade_1(subsystem1 , subsystem2);
            Client.ClientCode(facade);

            Console.ReadKey();
            
        }
    }
}
