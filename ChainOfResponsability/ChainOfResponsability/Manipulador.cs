using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Manipulador
    {
        protected Manipulador sucessor;

        public void defineSucessor(Manipulador sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void Convoca(int quantidadePoder);
    }
}
