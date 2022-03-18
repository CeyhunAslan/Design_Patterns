using Bridge.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example_1.Concrete.Shape_Concrete
{
    public class Square : Shape
    {
        public Square(Color color) : base(color)
        {

        }
        // Şekilin adını ve rengini verdim.
        public override string ToString()
        {
            return string.Format("The color for the square is {0}", this.GetColorString());
        }
    }
}
