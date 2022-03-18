using Observer.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer.Example_1
{
    // Özne bazı önemli durumlara sahiptir ve durum değiştiğinde gözlemcilere haber verir.
    public class Subject : ISubject
    {
        // Basitlik adına, tüm aboneler için gerekli olan Öznenin durumu bu değişkende saklanır.
        public int State { get; set; } = -0;

        // Abone listesi. Gerçek hayatta, abone listesi daha kapsamlı bir şekilde saklanabilir (categorized by event type, etc.).
        private List<IObserver> _observers = new List<IObserver>();

        // Abonelik yönetimi methodları
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Her abonede bir güncelleme tetikleyin.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // Genellikle abonelik mantığı, bir Konunun gerçekten yapabileceklerinin yalnızca bir kısmıdır. Konular genellikle, önemli bir şey olmak üzereyken (veya ondan sonra) bir bildirim yöntemini tetikleyen bazı önemli iş mantığına sahiptir..
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
