using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IIterator
    {
        string primeiroItem { get; }
        string proximoItem { get; }
        string atualItem { get; }
        bool estaPronto { get; }
    }
}
