using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Mochila : IExpressao
    {
        private readonly IFerramenta ferramenta_principal;
        private readonly IFerramenta ferramenta_secundaria;
        private readonly IArmamento armamento;

        public Mochila(IFerramenta ferramenta_principal, 
                        IFerramenta ferramenta_secundaria,
                        IArmamento armamento)
        {
            this.ferramenta_principal = ferramenta_principal;
            this.ferramenta_secundaria = ferramenta_secundaria;
            this.armamento = armamento;
        }

        public void Interpretar(Contexto contexto)
        {
            contexto.Conteudo += "Abrindo a Mochila... \n";

            armamento.Interpretar(contexto);
            contexto.Conteudo += "- 1º Ferramenta";
            ferramenta_principal.Interpretar(contexto);
            contexto.Conteudo += "- 2º Ferramenta";
            ferramenta_secundaria.Interpretar(contexto);

            contexto.Conteudo += "\n... Fechando Mochila";

            Console.WriteLine(contexto.Conteudo);
        }
    }
}
