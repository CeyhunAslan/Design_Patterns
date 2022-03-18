using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Abstract_Builder
{
    public abstract class PizzaBuilder 
    {

        protected Pizza pizza;

        public Pizza getPizza()
        {
            return pizza;
        }

        public void createNewPizzaProduct()
        {
            pizza = new Pizza();
        }

        public abstract void buildDough();

        public abstract void buildSauce();

        public abstract void buildTopping();
    }

}
