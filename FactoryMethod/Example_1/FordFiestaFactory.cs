using FactoryMethod.Example_1.Concrete;
using FactoryMethod.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example_1
{
    internal class FordFiestaFactory : ICreateCars
    {
        public Car CreateACar(string colour)
        {
            return new FordFiesta()
            {
                Colour = colour
            };
        }
    }
}
