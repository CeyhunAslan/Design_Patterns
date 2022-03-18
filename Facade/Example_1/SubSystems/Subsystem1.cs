using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example_1.SubSystems
{
    public class Subsystem1
    {
    //    Alt Sistem, cepheden veya istemciden gelen talepleri kabul edebilir.
    //  direkt olarak.Her durumda, Alt Sistem için Cephe başka bir şeydir.
    //istemcidir ve Alt Sistemin bir parçası değildir.
        public string operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string operationN()
        {
            return "Subsystem1: Go!\n";
        }
    }
}
