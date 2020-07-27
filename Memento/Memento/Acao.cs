using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Acao
    {
        public string _estado;

        public string Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                Console.WriteLine("Estado do jogo = " + _estado);
            }
        }

        public Memento CriarMemento()
        {
            return (new Memento(_estado));
        }

        public void RestaurarEstado(Memento memento)
        {
            Console.WriteLine("Restaurando o estado ... ");
            this.Estado = memento.Estado;
        }
    }
}
