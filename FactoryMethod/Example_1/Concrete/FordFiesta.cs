using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example_1.Concrete
{
    public class FordFiesta :Car
    {
        public FordFiesta()
        {
            Make = "Ford";
            Model = "Fiesta";
            EngineSize = "2.6";
        }
    }
}
