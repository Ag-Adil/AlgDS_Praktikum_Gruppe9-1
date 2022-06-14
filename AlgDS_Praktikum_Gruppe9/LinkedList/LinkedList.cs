using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    abstract class LinkedList : IDictionary
    {
        // Doppelt verkettete Liste implementieren für 
        // SetSorted
        //  bei SetSorted kann dadurch die Suche in der mitte starten und abgleichen,
        //  ob der gesuchte Wert größer oder kleiner ist, das einfügen geschieht an der Stelle,
        //  an welcher der Folgewert > der neue Wert ist
        //  delete wird die search funktion durchgeführt und bei true das element gelöscht
        //  (mäglicherweise indexer Implementieren)

        // bei unsorted kann das neue element einfach am ende eingefügt werden 
        protected class Node
        {
            public int inhalt;
            public int index;
            public Node next;
            public Node prev;
        }
        protected Node head;
        protected Node current;
        protected Node foot;
        // methode implementieren die bei search ein array anlegt wo alle werte die gesucht werden einen index in ein array anlegen

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
                    if (current.next.inhalt == elem)
                    {
                        return true;
                    }
                    
                    current = current.next;
                }
            }
            return false;
        }
        public void print()
        {
            Node node = head;
            string ausgabe = "";
            if (node == null)
            {
                Console.WriteLine("Liste: ");
            }
            else if (node.next == null)
            {
                ausgabe += $"{node.inhalt,3} ";
            }
            else
            {
                while (node != null)
                {
                    ausgabe += $"{node.inhalt,3} ";
                    node = node.next;
                }
            }
            if (ausgabe.Length > 1)
            {
                Console.WriteLine($"Liste: {ausgabe}");
            }
        }

        public abstract bool insert(int elem);
        //{
        //    throw new NotImplementedException();
        //}

        public bool delete(int elem)
        {
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
        // gibt eine liste der Indexe zurück an welchen sich das gesuchte element befindet
        public SetSortedLinkedList searchIndex(int elem)
        {
            int size = 0;
            SetSortedLinkedList setSortedLinkedList = new SetSortedLinkedList();
            Node node = head;
            while(node != null)
            {
                if (node.inhalt == elem)
                {
                    setSortedLinkedList.insert(size);
                }
                size++;
                node = node.next;
            }
            return setSortedLinkedList;


        }
        // Indexer Funktion implementieren
        // Letzter Test
    }
}
