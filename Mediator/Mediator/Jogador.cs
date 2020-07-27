using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Jogador
    {
        protected Mediador mediador;

        public Jogador(Mediador mediador)
        {
            this.mediador = mediador;
        }
    }
}
