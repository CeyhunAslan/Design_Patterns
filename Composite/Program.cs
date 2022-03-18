
using Composite.Example_1;
using Composite.Example_1.Client;
using Composite.Example_1.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();

            // Bu şekilde müşteri kodu basit Leaf destekleyebilir
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ......hem de karmaşık kompozitler.
            Composite_ tree = new Composite_();
            Composite_ branch1 = new Composite_();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite_ branch2 = new Composite_();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);

            Console.ReadKey();
        }
    }
}
