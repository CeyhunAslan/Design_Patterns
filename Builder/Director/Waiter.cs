using Builder.Abstract_Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class Waiter
    {

        private PizzaBuilder pizzaBuilder;

        public void setPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }

        public Pizza getPizza()
        {
            return pizzaBuilder.getPizza();
        }

        public void constructPizza()
        {
            pizzaBuilder.createNewPizzaProduct();
            pizzaBuilder.buildDough();
            pizzaBuilder.buildSauce();
            pizzaBuilder.buildTopping();
        }

        public void constructPizzaWithoutSause() 
        {
            pizzaBuilder.createNewPizzaProduct();
            pizzaBuilder.buildDough();
            pizzaBuilder.buildTopping();
        }
    }

}
