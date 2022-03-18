using FactoryMethod.Example_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example_2.Concrete
{
    internal class Highway : ILogistics
    {
        public string transportation()
        {
            return "From Roma";
        }
    }
}
