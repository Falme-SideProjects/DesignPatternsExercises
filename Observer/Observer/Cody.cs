using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Cody : IPersonagem
    {
        private List<IObservador> inimigos = new List<IObservador>();
        public int vida = 100;

        public void NotificarPersonagens()
        {
            foreach (IObservador i in inimigos)
                i.Avisar(this);
        }

        public void RegistrarObservador(IObservador observador)
        {
            inimigos.Add(observador);
        }

        public void Golpe_Acertado(bool golpe)
        {
            if (golpe)
                vida -= 10;

            NotificarPersonagens();
        }

        public int getVida()
        {
            return vida;
        }
    }
}
