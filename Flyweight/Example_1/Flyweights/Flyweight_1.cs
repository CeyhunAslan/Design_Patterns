using Flyweight.Example_1.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Example_1.Flyweights
{
    public class Flyweight_1
    {
        //Flyweight, birden çok gerçek ticari varlığa ait olan durumun ortak bir bölümünü(iç durum olarak da adlandırılır) saklar.Flyweight, durumun geri kalanını(dışsal durum, her varlık için benzersiz) kendi yöntem parametreleri aracılığıyla kabul eder.

        private Car _sharedState;

        public Flyweight_1(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
