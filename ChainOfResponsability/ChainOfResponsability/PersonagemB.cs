using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class PersonagemB : Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if (quantidadePoder >= 10 && quantidadePoder < 20)
                Console.WriteLine("{0} convocado para uma força de poder de {1}",
                    this.GetType(), quantidadePoder);
            else if (sucessor != null)
                sucessor.Convoca(quantidadePoder);
        }
    }
}
