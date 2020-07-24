using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class MoldeArmadura
    {
        private string _descricao = "Armadura do Personagem Abstrata";

        public virtual string Descricao
        {
            get { return _descricao; }
        }
    }
}
