using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}
