using Proxy.Example_1.Concrete;
using Proxy.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example_1.Proxys
{
    // Proxy, RealSubject ile aynı arabirime sahiptir.
    public class Proxy_1 : ISubject
    {
        private RealSubject _realSubject;
        
        public Proxy_1(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        // Proxy modelinin en yaygın uygulamaları tembel yükleme, önbelleğe alma, erişimi kontrol etme, günlüğe kaydetme vb.
        //bunlardan biri ve daha sonra sonuca bağlı olarak,
        //bağlantılı bir RealSubject nesnesinde aynı yöntemle yürütme.
        public void Request()
        {
            if (this.CheckAccess())
            {
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            // Bazı gerçek kontroller buraya gitmeli.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}
