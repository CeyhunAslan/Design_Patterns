using Composite.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example_1
{
    class Composite_ : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }


       // Bileşik, birincil mantığını belirli bir şekilde yürütür.Bilişim Teknoloji sonuçlarını toplayarak ve özetleyerek tüm çocukları arasında yinelemeli bir şekilde gezinir. Kompozitin çocukları bu çağrıları çocuklarına vb. ilettiğinden, sonuç olarak tüm nesne ağacı geçilir.

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (Component component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
