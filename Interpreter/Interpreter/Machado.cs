using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Machado : IArmamento
    {
        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += String.Format(" {0} ", " Machado ");
        }
    }
}
