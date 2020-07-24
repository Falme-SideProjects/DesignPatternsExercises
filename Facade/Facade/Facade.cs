using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private SubSistemaUm subSistemaUm;
        private SubSistemaDois subSistemaDois;
        private SubSistemaTres subSistemaTres;

        public Facade()
        {
            this.subSistemaUm = new SubSistemaUm();
            this.subSistemaDois = new SubSistemaDois();
            this.subSistemaTres = new SubSistemaTres();
        }

        public void OperacaoA()
        {
            Console.WriteLine("\nOperaçao A --------- ");
            this.subSistemaUm.Responsabilidade();
            this.subSistemaDois.Responsabilidade();
        }

        public void OperacaoB()
        {
            Console.WriteLine("\nOperação B --------- ");
            this.subSistemaTres.Responsabilidade();
        }
    }
}
