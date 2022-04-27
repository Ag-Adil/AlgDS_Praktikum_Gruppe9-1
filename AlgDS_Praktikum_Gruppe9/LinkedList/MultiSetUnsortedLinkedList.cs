using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class MultiSetUnsortedLinkedList : LinkedList, IMultiSetUnsorted
    {
        int size = 0;
        public new bool insert(int elem)
        {
            // einfache add funktion, element wird am ende eingefügt
            size++;
            Node node = new Node();
            node.inhalt = elem;
            node.index = size;
            if (head == null)
            {
                head = node;
            }
            else
            {
                current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
            return true;
        }
    }
}
