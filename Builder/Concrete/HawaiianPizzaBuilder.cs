using Builder.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void buildDough()
        {
            pizza.setDough("thick");//Hamuru kalın
        }

        public override void buildSauce()
        {
            pizza.setSauce("Hot");
        }

        public override void buildTopping()
        {
            pizza.setTopping("ham + pineapple"); //Janbon ve ananas
        }
    }
}
