using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example_1.Abstract
{
    public abstract class Shape
    {
        //Shape classım içinden Color clasımı _color değişkenimin içine atıyorum.
        protected Color _color;

        //Böylellikle Color ve Sahpe absract classlarım arasında bir köpri kurdum.
        public Shape(Color color)
        {
            this._color = color;
        }

        //hangi renkten ne kadar var 
        public string GetColorString()
        {

            return string.Format("The color is R={0} G={1} B={2}", _color.Red, _color.Green, _color.Blue);
        }
    }
}
