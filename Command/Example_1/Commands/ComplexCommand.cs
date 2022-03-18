using Command.Example_1.Interface;
using Command.Example_1.Transceiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Example_1.Commands
{
    // Ancak, bazı komutlar daha karmaşık işlemleri "alıcılar" adı verilen diğer nesnelere devredebilir."
    class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        // Alıcının yöntemlerini başlatmak için gerekli olan bağlam verileri.
        private string _a;

        private string _b;

        // Karmaşık komutlar, yapıcı aracılığıyla herhangi bir bağlam verisiyle birlikte bir veya birkaç alıcı nesnesini kabul edebilir.
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        // Commands can delegate to any methods of a receiver.
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}
