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

        public void PrintList()
        {
            var currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }

        public void AddFirst(T data)
        {
            Node<T> temp = new Node<T>();
            temp.Data = data;
            temp.Next = head;
            head = temp;
        }

        public void AddLast(T data)
        {
            Node<T> temp = new Node<T>();
            var currentNode = head;
            temp.Data = data;

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

        public void RemoveLast()
        {
            var currentNode = head;

            if(head == null)
            {
                return;
            }
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode = null;
        }

        public T GetValue(int index)
        {
            var currentNode = head;
            for (int i = 0; index - 1 > i; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Data;
        }

        public void RemoveValue(T data)
        {
            var currentNode = head;

            while(true)
            {
                if(!currentNode.Next.Data.Equals(data))
                {
                    currentNode = currentNode.Next;
                } else
                {
                    currentNode.Next = currentNode.Next.Next;
                    return;
                }
            }
        }
    }
}
