using Flyweight.Example_1.Entities;
using Flyweight.Example_1.Flyweights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Example_1.FlyweightFactorys
{
    public class FlyweightFactory
    {

        //Flyweight Factory, Flyweight nesnelerini oluşturur ve yönetir.Flyweight ağırlıklarının doğru bir şekilde paylaşılmasını sağlar. İstemci bir hafif ağırlık istediğinde, fabrika ya mevcut bir örneği döndürür ya da henüz mevcut değilse yeni bir örnek oluşturur.
        private List<Tuple<Flyweight_1, string>> flyweights = new List<Tuple<Flyweight_1, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight_1, string>(new Flyweight_1(elem), this.getKey(elem)));
            }
        }

        // Belirli bir durum için bir Flyweight'in dize karmasını döndürür.
        public string getKey(Car key)
        {
            List<string> elements = new List<string>();

            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);

            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Belirli bir duruma sahip mevcut bir Flyweight döndürür veya yeni bir tane oluşturur.
        public Flyweight_1 GetFlyweight(Car sharedState)
        {
            string key = this.getKey(sharedState);

            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight_1, string>(new Flyweight_1(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void listFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }
}
