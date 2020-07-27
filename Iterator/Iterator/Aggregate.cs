using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Aggregate : IAggregate
    {
        List<string> colecao = null;

        public Aggregate()
        {
            colecao = new List<string>();
        }

        public string this[int indexItem] { 
            get
            {
                if (indexItem < colecao.Count)
                    return colecao[indexItem];
                else
                    return string.Empty;
            }
            set
            {
                colecao.Add(value);
            }
        }

        public int Contador
        {
            get
            {
                return colecao.Count;
            }
        }

        public IIterator GetIterator()
        {
            //????
            return new Iterator(this);
        }

    }
}
