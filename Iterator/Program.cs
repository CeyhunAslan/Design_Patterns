using Iterator.Example_1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İstemci kodu, programınızda tutmak istediğiniz dolaylılık düzeyine bağlı olarak Beton Yineleyici veya Koleksiyon sınıfları hakkında bilgi sahibi olabilir veya olmayabilir.
            var collection = new WordsCollection();
            collection.AddItem("First");
            collection.AddItem("Second");
            collection.AddItem("Third");

            Console.WriteLine("Straight traversal:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
