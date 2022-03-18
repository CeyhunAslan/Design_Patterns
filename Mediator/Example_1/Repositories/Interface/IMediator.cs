using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Example_1.Repositories.Interface
{
    // Arabulucu arabirimi, bileşenler tarafından aracıyı çeşitli olaylar hakkında bilgilendirmek için kullanılan bir yöntemi bildirir. Arabulucu bu olaylara tepki verebilir ve yürütmeyi diğer bileşenlere aktarabilir.
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
