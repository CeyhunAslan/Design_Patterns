using Proxy.Example_1.Clients;
using Proxy.Example_1.Concrete;
using Proxy.Example_1.Proxys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Client client = new Client();

                Console.WriteLine("Client: Executing the client code with a real subject:");
                RealSubject realSubject = new RealSubject();
                client.ClientCode(realSubject);

                Console.WriteLine();

                Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy_1 proxy = new Proxy_1(realSubject);
            client.ClientCode(proxy);
            
        }
    }
}
