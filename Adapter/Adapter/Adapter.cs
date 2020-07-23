using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter :IAcao
    {
        Aviao aviao;

        public Adapter(Aviao novoAviao)
        {
            this.aviao = novoAviao;
        }

        public void Andar(string jogador)
        {
            this.aviao.Voar(jogador);
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
