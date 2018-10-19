using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkadLista
{
    class LLista<T>
    {
        private Node<T> head;

        public void AddFirst(T data)
        {
            Node<T> temp = new Node<T>();
            temp.Next = head;
            head = temp;
        }

        public void AddLast(T data)
        {
            Node<T> temp = new Node<T>();
            var currentNode = head;
            if(head == null)
            {
                head = temp;
                return;
            }
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = temp;
        }

        public void RemoveFirst()
        {
            if(head == null)
            {
                return;
            }

            head = head.Next;
        }

        public void RemoveLast(T data)
        {
            var currentNode = head;

            if(head == null)
            {
                return;
            }
            while (currentNode.Next != null)
            {
                currentNode = null;
            }
        }
    }
}
