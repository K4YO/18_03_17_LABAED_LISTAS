using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLibrary
{
    public sealed class Element
    {
        private Data data;
        internal Element previous;
        internal Element next;

        public Data Data { get => data; }
        public Element Next { get => next; set => next = value; }
        public Element Previous { get => previous; set => previous = value; }

        public Element(Data d)
        {
            this.data = d;
            this.next = null;
            this.previous = null;
        }
       
    }
}
