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
            
            return Suchen(elem);
        }
        public bool delete(int elem)
        {
            // Problem: wenn listen länge kleiner gleich 2
            while (search(elem))
            {
                if (head.inhalt == elem)
                {
                    head = head.next;
                }
                else
                {
                    current = head;
                    while (current.next != null)
                    {
                        if (current.next.inhalt == elem)
                        {
                            current.next = current.next.next;
                        }
                        current = current.next;
                    }
                }
            }
            return true;
        }

        public bool insert(int elem)
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

        public void print()
        {
            Console.WriteLine(Ausgabe());
        }
    }
}
