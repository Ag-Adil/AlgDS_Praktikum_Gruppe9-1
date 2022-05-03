using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class MultiSetUnsortedLinkedList : LinkedList, IMultiSetUnsorted
    {
        public override bool insert(int elem)
        {
            // einfache add funktion, element wird am ende eingefügt
            Node node = new Node();
            node.inhalt = elem;
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
