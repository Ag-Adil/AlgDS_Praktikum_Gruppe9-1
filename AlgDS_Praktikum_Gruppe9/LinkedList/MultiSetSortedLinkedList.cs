using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class MultiSetSortedLinkedList : LinkedList, IMultiSetSorted
    {
        public bool search(int elem)
        {
            return Suchen(elem);
        }
        public bool delete(int elem)
        {
            return true;
        }

        public bool insert(int elem)
        {
            return true;
        }

        public void print()
        {
            Console.WriteLine(Ausgabe());
        }
    }
}
