using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Aviao
    {
        public void Voar(string personagem)
        {
            Console.WriteLine(personagem + " Voou pra frente!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil no jogo!");
        }
    }
}
