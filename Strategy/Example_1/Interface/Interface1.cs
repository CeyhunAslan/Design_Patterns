using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Example_1.Interface
{
    // Strateji arabirimi, bazı algoritmaların desteklenen tüm sürümleri için ortak olan işlemleri bildirir.
    //
    // Context, Somut Stratejiler tarafından tanımlanan algoritmayı çağırmak için bu arayüzü kullanır.
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
