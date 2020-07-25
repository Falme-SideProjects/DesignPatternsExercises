using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFase proxy = new ProxyFase();

            Console.WriteLine("#### Usando o proxy para controlar o  acesso a fase do jogo ####");
            Console.WriteLine();

            Console.WriteLine(proxy.InformarPassword("345"));
            Console.WriteLine(proxy.Jogar());

            Console.ReadKey();

            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());

            Console.ReadKey();
        }

        public void WithProxy()
        {
            Console.WriteLine("#### Usando o proxy para controlar o  acesso a fase do jogo ####");
            Console.WriteLine();
            ProxyFase proxy = new ProxyFase();

            Console.WriteLine(proxy.Jogar());

            Console.ReadKey();
        }

        public void WOproxy()
        {
            Console.WriteLine("#### Acessando a fase do jogo sem o Proxy ####");
            FaseJogo fase = new FaseJogo();
            Console.WriteLine(fase.Jogar());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
