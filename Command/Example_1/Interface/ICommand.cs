using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Example_1.Interface
{
    // Komut arabirimi, bir komutun yürütülmesi için bir yöntem bildirir.
    public interface ICommand
    {
        void Execute();
    }
}
