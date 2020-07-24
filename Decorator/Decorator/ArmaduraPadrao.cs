using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        string _descricao = "Protecao Simples, ";

        public override string Descricao
        {
            get
            {
                return _descricao;
            }
        }
    }
}
