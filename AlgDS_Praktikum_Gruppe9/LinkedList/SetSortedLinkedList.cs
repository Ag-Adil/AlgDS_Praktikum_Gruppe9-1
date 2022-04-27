using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class SetSortedLinkedList : MultiSetSortedLinkedList, ISetSorted
    {
        

        public new bool insert(int elem)
        {
            if (search(elem) == false)
            {
                // Logik funktioniert noch nicht -> muss überarbeitet werden
                Node node = new Node();
                node.inhalt = elem;
                if (head == null)
                {
                    head = node;
                    foot = head;
                }
                else
                {
                    if (node.inhalt <= head.inhalt)
                    {
                        Node temp = head;
                        head = node;
                        temp.prev = head;
                        head.next = temp;
                    }
                    else
                    {
                        current = head;
                        while (current.next != null && node.inhalt > current.inhalt)
                        {
                            current = current.next;
                        }
                        if (current.next == null && node.inhalt >= current.inhalt)
                        {
                            Node temp = foot;
                            foot = node;
                            temp.next = foot;
                            foot.prev = temp;

                        }
                        else
                        {
                            Node insert = node;
                            insert.next = current;
                            insert.prev = current.prev;
                            current.prev.next = insert;
                            current.prev = insert;
                        }
                    }

                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
