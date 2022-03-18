using Adapter.Example_1.Concrete;
using Adapter.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example_1.Target
{
    public class Adapter_1 : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter_1(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
