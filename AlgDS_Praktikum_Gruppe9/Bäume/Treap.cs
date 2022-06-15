using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class Treap : BinSearchTree, ISetSorted
    {
       protected class TreapNode
        {
            public int T_data { get; set; }
            public int Priority { get; set; }
            public TreapNode T_left, T_right;

            public TreapNode(int data)
            {
                this.T_data = data;
                this.Priority = new Random().Next(100);
                this.T_left = this.T_right = null;
            }
        }

        protected TreapNode T_root;

        public Treap()
        {
            T_root = null;
        }


        public new bool insert(int data)
        {
            TreapNode newItem = new TreapNode(data);
            if (T_root == null)
            {
                T_root = newItem;
            }
            else
            {
                T_root = insert(T_root, newItem);
            }
            return true;

        }

        /*Um ein neues Element in den Treap einzufügen, generieren wir eine zufällige 
         Priorität für das Element.
         Suchen wir das Element.T_data und erstellen wir einen neuen Knoten dafür 
         nur wenn das Element nicht vorhanden ist.
         dann führen wir, solange Element nicht die Wurzel des Baums ist und eine größere 
         Prioritätszahl als sein Elternteil hat, eine Baumdrehung (R||L) durch, die die 
         Eltern-Kind-Beziehung zwischen Element und Parent umkehrt.*/
        private TreapNode insert(TreapNode current, TreapNode n)
        {
            if (!search(n.T_data)) // neues Element wird hinzugefügt nur dann, wenn es im Baum nicht vorhanden ist
            {
                if (current == null)
                {
                    current = n;
                    return current;
                }
                if (n.T_data < current.T_data) // Das linke Kind 
                {
                    current.T_left = insert(current.T_left, n);
                    if (current.T_left != null && current.T_left.Priority > current.Priority)
                    {
                        current = rotateRight(current);
                    }
                }
                else // Das rechte Kind (n.T_data > current.T_data) 
                {
                    current.T_right = insert(current.T_right, n);
                    if (current.T_right != null && current.T_right.Priority > current.Priority)
                    {
                        current = rotateLeft(current);
                    }
                }
                return current;
            }
            // Element war schon vorhanden
            return null;
        }

        public new bool delete(int del_data)
        {
            if (delete(del_data, T_root) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private TreapNode delete(int del_data, TreapNode node)
        {
            if (node == null || !search(del_data)) // Baum ist leer oder das zu löschende Element ist nicht vorhanden
            {
                return null;
            }
            else // das zu löschende Element ist vorhanden
            {
                if (del_data < node.T_data) // das linke Kind
                {
                    node.T_left = delete(del_data, node.T_left);
                }
                else if (del_data > node.T_data) // das rechte Kind
                {
                    node.T_right = delete(del_data, node.T_right);
                }
                else // das zu löschende Element ist gefunden
                {
                    if (node.T_left == null && node.T_right == null) // es gibt keine Nachfolger 
                    {
                        node = null;
                    }
                    // es gibt rechten und linken Nachfolger
                    else if (node.T_left != null && node.T_right != null)
                    {
                        // der linke Nachfolger hat kleiner Priorität als der rechte Nachfolger
                        if (node.T_left.Priority < node.T_right.Priority)
                        {
                            node = rotateLeft(node);

                            // Nach Rotation muss del_data im linken Baum gelöscht
                            node.T_left = delete(del_data, node.T_left);
                        }
                        else
                        {
                            node = rotateRight(node);

                            // Nach Rotation muss del_data im rechten Baum gelöscht
                            node.T_right = delete(del_data, node.T_right);
                        }
                    }
                    // das zu löschende Element hat nur einen Nachfolger
                    else
                    {
                        // Ersetzen mit seinem Kind 
                        TreapNode child = (node.T_left != null) ? node.T_left : node.T_right;
                        node = child;
                    }
                }
            }
            return node;
        }
        /* Um nach einem bestimmten Element zu suchen, wenden wir eine standardmethode,
           ähnlich wie von binären Suchbaum, wobei wir die Prioritäten ignorieren                      
          */
        public new bool search(int data)
        {
            TreapNode node = search(data, T_root); // Weiterleiten an private search

            if (node != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected TreapNode search(int data, TreapNode node)
        {
            /* das Suchen kann rekursiv stattfinden
              Es wird dabei der Wert von data mit 
              der Wert der aktuellen Node verglichen
              1. wenn kleiner, wird der linke Baum untersucht
              2. wenn krößer, wird der rechte Baum untersucht
              ... bis der Wert gefunden wurde, ansonsten return null*/
            if (node == null)
            {
                return null;
            }
            else if (data < node.T_data)
            {
                return search(data, node.T_left);
            }
            else if (data > node.T_data)
            {
                return search(data, node.T_right);
            }
            else
            {
                return node;
            }
        }
        public new void print()
        {
            if (T_root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            print(T_root, 0);
            Console.WriteLine();
        }
        private void print(TreapNode node, int space)
        {
            space += 10;

            if (node != null)
            {
                print(node.T_right, space);
                for (int i = 10; i < space; i++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine("({0},{1}) ", node.T_data, node.Priority);
                print(node.T_left, space);
            }
        }
        private TreapNode rotateLeft(TreapNode parent)
        {
            TreapNode R = parent.T_right;
            TreapNode X = parent.T_right.T_left;

            // Linksrotation
            R.T_left = parent;
            parent.T_right = X;

            // neues T_root einsetzen
            return R;
        }
        private TreapNode rotateRight(TreapNode parent)
        {
            TreapNode L = parent.T_left;
            TreapNode Y = parent.T_left.T_right;

            // Rechtsrotation
            L.T_right = parent;
            parent.T_left = Y;

            // neues T_root einsetzen
            return L;
        }
    }

}


