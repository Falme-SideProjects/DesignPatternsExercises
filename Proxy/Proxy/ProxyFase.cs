using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyFase : IFase
    {
        FaseJogo faseJogo;
        string password = "123";

        public string Jogar()
        {
            if (this.faseJogo != null)
                return faseJogo.Jogar();

            return "Informe o PASSWORD correto para abrir a fase do jogo!";
        }

        public string InformarPassword(string codigo)
        {
            if(codigo == this.password)
            {
                this.faseJogo = new FaseJogo();
                return "Password Correto!";
            }

            return "Password Incorreto!";
        }
    }
}
