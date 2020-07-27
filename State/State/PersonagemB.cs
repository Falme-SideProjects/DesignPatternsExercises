using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PersonagemB : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new PersonagemA();
        }
    }
}
