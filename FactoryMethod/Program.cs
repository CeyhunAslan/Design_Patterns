using FactoryMethod.Example_1;
using FactoryMethod.Example_1.Interface;
using FactoryMethod.Example_2;
using FactoryMethod.Example_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example_1
            var factory = new FordFiestaFactory() as ICreateCars;

            var MyCar = factory.CreateACar("Blue");


            Console.WriteLine("Make : " + MyCar.Make + " " + MyCar.Model + " " + MyCar.Colour);
           

            #endregion


            #region Example_2
            StartCommand startCommand = new StartCommand();

            ILogistics command;

            for (int i = 1; i < 12; i++)
            {
                command = startCommand.Factory_Method((i));

                Console.WriteLine($"{command.transportation()}");
                
            }

            #endregion
            Console.ReadKey();



        }
    }
}
