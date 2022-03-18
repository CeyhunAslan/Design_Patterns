using Bridge.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example_1.Concrete.Color_Concrete
{
    public class ColorRed :Color
    {
        public override int Red => 255;

        public override int Green => 0;

        public override int Blue => 0;
    }
}
