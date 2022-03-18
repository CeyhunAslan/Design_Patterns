using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Example_1.Transceiver
{
    // Alıcı sınıfları bazı önemli iş mantığını içerir. Bir talebin yerine getirilmesiyle ilgili her türlü işlemin nasıl gerçekleştirileceğini bilirler. Aslında, herhangi bir sınıf Alıcı işlevi görebilir.
    class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on ({b}.)");
        }
    }
}
