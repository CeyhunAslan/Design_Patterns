using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Example_1.Interface.Visitor
{
    // Bileşen arabirimi, temel ziyaretçi arabirimini bağımsız değişken olarak alması gereken bir "kabul" yöntemini bildirir.
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
