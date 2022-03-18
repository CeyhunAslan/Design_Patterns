using FactoryMethod.Example_2.Concrete;
using FactoryMethod.Example_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example_2
{
    public class StartCommand
    {

        public ILogistics Factory_Method(int command)
        {
            if (command == 3 || command == 6)
            {
                return new Highway();
            }
            else
            {
                if (command == 7 || command == 9)
                {
                    return new Seaway();
                }
                else
                {
                    return new Default();
                }
            }
        
        }
    }
}
