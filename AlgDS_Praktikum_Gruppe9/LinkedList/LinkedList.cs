using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class LinkedList
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
        }
        protected Node head;
        protected Node current;

        protected bool Suchen(int elem) // Hilfsfunktion wird in allen LinkedList Unterklassen verwendet
        {
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
        protected string Ausgabe() // Hilfsfunktion wird in allen LinkedList Unterklassen verwendet
        {
            Node node = head;
            string ausgabe = "";
            if (node == null)
            {
                return "Leere Liste";
            }
            else if (node.next == null)
            {
                ausgabe += $"{node.inhalt} ";
            }
            else
            {
                while (node != null)
                {
                    ausgabe += $"{node.inhalt} ";
                    node = node.next;
                }
            }
            return ausgabe;
        }

        // Indexer Funktion implementieren
        // Letzter Test
    }
}
