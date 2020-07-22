using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}
