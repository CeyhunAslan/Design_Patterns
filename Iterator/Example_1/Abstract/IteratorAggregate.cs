using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example_1.Abstract
{
    abstract class IteratorAggregate : IEnumerable
    {
        //Uygulama nesnesi için bir Yineleyici veya başka bir IteratorAggregate döndürür.
        public abstract IEnumerator GetEnumerator();
    }

}
