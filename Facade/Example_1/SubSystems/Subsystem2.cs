using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Example_1.SubSystems
{
    public class Subsystem2
    {
        //Bazı cepheler aynı anda birden fazla alt sistemle çalışabilir.
        public string operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string operationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }

}
