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
        public bool search(int elem)
        {
            // kann von der theorie in der elternklasse implementiert werden
            // dafür muss dann aber ein index angelegt werden um deleten an der richtigen stelle durchzuführen
            if (head == null)
            {
                return false;
            }
            if (head.inhalt == elem)
            {
                return true;
            }
            else
            {
                current = head;
                while (current.next != null)
                {
                    if (current.inhalt == elem)
                    {
                        return true;
                    }
                    current = current.next;
                }
            }
            return false;
        }
        public bool delete(int elem)
        {
            return true;
        }

        public bool insert(int elem)
        {
            // einfache add funktion, element wird am ende eingefügt
            size++;
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

        public void print()
        {
            Console.WriteLine(Ausgabe());
        }
    }
}
