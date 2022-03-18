using Decorator.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example_1.Concrete
{
    internal class Bilesen : IBilesen
    {
        //İmzası olan methoda gövde yazdım
        public string Operation()
        {
            return "M4 Assult Rifle";
        }
    }
}
