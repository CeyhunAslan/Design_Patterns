using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example_1
{
    public abstract class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineSize { get; set; }
        public string Colour { get; set; }

    }
}
