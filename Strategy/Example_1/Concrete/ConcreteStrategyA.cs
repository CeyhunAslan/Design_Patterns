using Strategy.Example_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Example_1.Concrete
{
    // Somut Stratejiler, temel Strateji arayüzünü takip ederken algoritmayı uygular. Arayüz, onları Bağlamda değiştirilebilir hale getirir.
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
