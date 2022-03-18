using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example_1.Abstract
{
    abstract class Iterator_ : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Geçerli öğenin anahtarını döndürür
        public abstract int Key();

        // Geçerli öğeyi döndürür
        public abstract object Current();

        // Sonraki öğeye ilerle
        public abstract bool MoveNext();

        // Yineleyiciyi ilk öğeye geri sarar
        public abstract void Reset();
    }
}
