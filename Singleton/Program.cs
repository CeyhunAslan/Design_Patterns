
using Singleton.Example_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aşağıda gördüğünüz gibi Singleton_Class sınıfının insatance'sini alamadık. Çünkü sınıfın constructor'u private.
            //Singleton_Class singleton_Class = new Singleton_Class();



            var singleton_Class = Singleton_Class.Instance();
            //Methodumuz vasıtasıyla Singleton classımızı çağırdık 

          
            //aşağıda Sinleton clasımın içindeki bir üyeyi çağırarak kulandım
            Console.WriteLine($"Sonuc: {singleton_Class.Toplam(5 , 6)}");
            Console.ReadKey();

        }
    }
}
