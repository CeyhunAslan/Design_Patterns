using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example_1.Abstract
{
    public abstract class Color
    {
        //Ana Renkler bu renkler karıştırılarak her renk çıkarılabilir.
        //Propertylerimde set yok çünkü proretylerime değer verilsin istemiyorum onlar istediği değerleri versinler
        public abstract int Red { get; }

        public abstract int Green { get; }

        public abstract int Blue { get; }
    }
}
