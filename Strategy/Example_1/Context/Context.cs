using Strategy.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Example_1.Context
{
    // Bağlam, istemcilerin ilgileneceği arayüzü tanımlar.
    class Context
    {
        // Bağlam, Strateji nesnelerinden birine bir referansı korur. Bağlam, bir stratejinin somut sınıfını bilmiyor. Strateji arayüzü aracılığıyla tüm stratejilerle çalışmalıdır.
        private IStrategy _strategy;

        public Context()
        { }

        // Genellikle Context, yapıcı aracılığıyla bir stratejiyi kabul eder, ancak çalışma zamanında bunu değiştirmek için bir ayarlayıcı da sağlar.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Genellikle, Bağlam çalışma zamanında bir Strateji nesnesinin değiştirilmesine izin verir.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Bağlam, algoritmanın birden çok sürümünü kendi başına uygulamak yerine bazı işleri Strateji nesnesine devreder.
        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }

}
