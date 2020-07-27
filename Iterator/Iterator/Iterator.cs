using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Iterator : IIterator
    {
        private Aggregate aggregate;

        public Iterator(Aggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public string primeiroItem => throw new NotImplementedException();

        public string proximoItem => throw new NotImplementedException();

        public string atualItem => throw new NotImplementedException();

        public bool estaPronto => throw new NotImplementedException();
    }
}
