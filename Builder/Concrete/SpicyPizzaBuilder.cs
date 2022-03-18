using Builder.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concrete
{
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void buildDough()
        {
            pizza.setDough("thin");//Hamuru İnce
        }

        public override void buildSauce()
        {
            pizza.setSauce("hot");
        }

        public override void buildTopping()
        {
            pizza.setTopping("pepperoni + salami");
        }
    }
}
