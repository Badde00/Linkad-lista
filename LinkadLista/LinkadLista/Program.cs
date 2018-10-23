using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkadLista
{
    class Program
    {
        static void Main(string[] args)
        {
            LLista<int> test = new LLista<int>();
            test.AddFirst(7);
            test.AddFirst(6);
            test.AddFirst(-12);
            test.RemoveLast();
            test.AddLast(999);
            test.RemoveFirst();

            test.PrintList();

        }


    }
}
