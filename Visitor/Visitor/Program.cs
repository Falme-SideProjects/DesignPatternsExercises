using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IJogo> jogo = new List<IJogo>();
            jogo.Add(new FaseJogo() { NomeFase = "Floresta" });
            jogo.Add(new FaseJogo() { NomeFase = "Caverna" });
            jogo.Add(new Chefao() { NomeChefao = "Boss 1" });
            jogo.Add(new Chefao() { NomeChefao = "Boss 2" });

            NivelVisitor niveis = new NivelVisitor();
            foreach(var etapa in jogo)
            {
                etapa.Visitante(niveis);
            }

            Console.ReadKey();
        }
    }
}
