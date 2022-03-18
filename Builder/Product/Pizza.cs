using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    public class Pizza
    {
        private string dough = "";
        private string sauce = ""; 
        private string topping = ""; 

        public void setDough(string dough)
        {
            this.dough = dough;
        }

        public void setSauce(string sauce)
        {
            this.sauce = sauce;
        }

        public void setTopping(string topping)
        {
            this.topping = topping;
        }
    }
}
