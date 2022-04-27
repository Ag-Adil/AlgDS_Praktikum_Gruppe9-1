using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class SetUnsortedLinkedList : MultiSetUnsortedLinkedList, ISetUnsorted
    {
        public new bool insert(int elem)
        {
            if (search(elem) == true)
            {
                return false;
            }
            else
            {
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
            }
            return true;
        }
    }
}
