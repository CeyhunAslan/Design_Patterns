using Decorator.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example_1.Decarators
{
    public class Decorator_B : IBilesen
    {
        //Silahımı Ağır namlu takar dekore ettim.
        private IBilesen _bilen;

        public Decorator_B(IBilesen bilesen)
        {
            this._bilen = bilesen;
        }

        public string Operation()
        {
            return $"{_bilen.Operation()} add heavy barrel..!";
        }
    }
}
