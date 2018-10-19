using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkadLista
{
    class Node<T>
    {
        T data;
        Node<T> next;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
