using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Personagem : IAcao
    {
        public void Atirar()
        {
            Console.WriteLine("Atirou o jogo!");
        }

        public void Andar(string personagem)
        {
            Console.WriteLine(personagem+" Andou no jogo!");
        }
    }
}
