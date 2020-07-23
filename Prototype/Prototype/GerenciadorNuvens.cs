using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class GerenciadorNuvens
    {
        private Dictionary<string, NuvemMolde> nuvens = 
            new Dictionary<string, NuvemMolde>();

        public NuvemMolde this[string key]
        {
            get { return nuvens[key]; }
            set { nuvens.Add(key, value); }
        }
    }
}
