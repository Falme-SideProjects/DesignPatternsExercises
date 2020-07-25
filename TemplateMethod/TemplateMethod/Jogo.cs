using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Jogo
    {
        public Jogo()
        {
            TrilhaSonora();
            PrimeiraFase();
            SegundaFase();
        }

        public abstract void PrimeiraFase();
        public abstract void SegundaFase();

        private void TrilhaSonora()
        {
            Console.WriteLine("Musica emocionante");
        }
    }
}
