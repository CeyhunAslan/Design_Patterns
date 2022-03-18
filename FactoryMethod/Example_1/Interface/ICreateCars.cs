using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example_1.Interface
{
    internal interface ICreateCars
    {
        Car CreateACar(string colour);
    }
}
