using Memento.Example_1.Repositories.Concrete;
using Memento.Example_1.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Memento.Example_1.Momento
{
    // Oluşturan, zamanla değişebilecek bazı önemli durumlara sahiptir. Aynı zamanda bir memento içindeki durumu kaydetmek için bir yöntem ve durumu ondan geri yüklemek için başka bir yöntem tanımlar.
    class Originator
    {
        // Basitlik adına, oluşturucunun durumu tek bir değişken içinde saklanır.
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Originator: My initial state is: " + state);
        }

        // Oluşturanın iş mantığı, dahili durumunu etkileyebilir. Bu nedenle, istemci, save()
        // yöntemi aracılığıyla iş mantığının yöntemlerini başlatmadan önce durumu yedeklemelidir.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Originator: and my state has changed to: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Mevcut durumu bir memento içinde kaydeder.
        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        // Bir memento nesnesinden Oluşturan'ın durumunu geri yükler.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }
}
