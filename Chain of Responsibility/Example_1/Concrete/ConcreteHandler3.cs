using Chain_of_Responsibility.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Example_1.Concrete
{
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
