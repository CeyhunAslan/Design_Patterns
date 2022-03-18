using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example_1.Interface
{
    //Hedef, istemci kodu tarafından kullanılan alana özgü arabirimi tanımlar.
    internal interface ITarget
    {
        string GetRequest();
    }
}
