using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public interface IExpressao
    {
        void Interpretar(Contexto contexto);
    }
}
