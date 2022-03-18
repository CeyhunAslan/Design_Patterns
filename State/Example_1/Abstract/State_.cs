using State.Example_1.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Example_1.Abstract
{
    // Temel State sınıfı, tüm Somut Durumun uygulaması gereken yöntemleri bildirir
    // ve ayrıca State ile ilişkili Context nesnesine bir geri başvuru sağlar.
    // Bu geri referans, Devletler tarafından İçeriği başka bir  state geçirmek için kullanılabilir.
    abstract class State_
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }

}
