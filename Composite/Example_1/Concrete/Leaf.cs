using Composite.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example_1.Concrete
{

    //Yaprak sınıfı, bir kompozisyonun son nesnelerini temsil eder.Bir yaprağın çocuğu olamaz.Genellikle asıl işi yapanlar Leaf nesneleridir, oysa Kompozit nesneler yalnızca kendi alt bileşenlerine yetki verir.
    class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;

        }
    }
}