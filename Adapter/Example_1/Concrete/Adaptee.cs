using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example_1.Concrete
{
    //Adaptee bazı yararlı davranışlar içeriyor, ancak arayüzü mevcut istemci koduyla uyumlu değil. Adaptee, istemci kodunun kullanabilmesi için önce bazı uyarlamalara ihtiyaç duyar.
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
