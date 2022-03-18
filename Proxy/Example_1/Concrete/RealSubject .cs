using Proxy.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Example_1.Concrete
{
    //RealSubject bazı temel iş mantığını içerir.Genellikle RealSubjects, çok yavaş veya hassas olabilecek bazı yararlı işler yapabilir - ör.giriş verilerinin düzeltilmesi.Bir Proxy, RealSubject'in kodunda herhangi bir değişiklik yapmadan bu sorunları çözebilir.
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
