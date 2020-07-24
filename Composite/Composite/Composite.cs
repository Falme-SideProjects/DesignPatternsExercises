using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : ComponenteFase
    {
        private List<ComponenteFase> fasesJogo = new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {

        }

        public override void Adicionar(ComponenteFase c)
        {
            this.fasesJogo.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach(ComponenteFase item in this.fasesJogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase c)
        {
            this.fasesJogo.Remove(c);
        }
    }
}
