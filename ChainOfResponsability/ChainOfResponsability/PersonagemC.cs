using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class PersonagemC : Manipulador
    {
        public override void Convoca(int quantidadePoder)
        {
            if (quantidadePoder >= 20 && quantidadePoder < 30)
                Console.WriteLine("{0} convocado para uma força de poder de {1}",
                    this.GetType(), quantidadePoder);
            else if (sucessor != null)
                sucessor.Convoca(quantidadePoder);
        }
    }
}
