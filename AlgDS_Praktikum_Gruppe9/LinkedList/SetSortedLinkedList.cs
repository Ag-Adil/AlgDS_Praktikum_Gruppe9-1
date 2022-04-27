using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class SetSortedLinkedList : MultiSetSortedLinkedList, ISetSorted
    {
        //public bool search(int elem)
        //{
        //    return Suchen(elem);
        //}
        //public bool delete(int elem)
        //{
        //    return true;
        //}

        public new bool insert(int elem)
        {
            // Logik funktioniert noch nicht -> muss überarbeitet werden
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
                    if (current.next.inhalt >= node.inhalt)
                    {
                        break;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
                current.next = node;
                
            }
            return true;
        }

        //public void print()
        //{
        //    Console.WriteLine(Ausgabe());
        //}
    }
}
