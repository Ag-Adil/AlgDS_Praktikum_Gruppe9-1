using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class AVLTree : BinSearchTree, ISetSorted
    {
        public new bool insert(int data)
        {
            Node newItem = new Node(data);
            if (root == null)
            {
                root = newItem;
            }
            else // Weiterleiten an private Insert
            {
                root = insert(root, newItem);
            }
            return true;
        }
        private Node insert(Node current, Node n)
        {

            if (!search(n.Data)) // neues Element wird hinzugefügt nur dann, 
            {                    // wenn es im Baum nicht vorhanden ist 
                if (current == null)
                {
                    current = n;
                    return current;
                }
                else if (n.Data < current.Data) // das linke Kind
                {
                    current.left = insert(current.left, n);
                    current = balance_tree(current);
                }
                else if (n.Data > current.Data) // das rechte Kind
                {
                    current.right = insert(current.right, n);
                    current = balance_tree(current);
                }
                return current;
            }
            return null;
        }
        private Node balance_tree(Node current)
        {
            int b_factor = balance_factor(current);
            if (b_factor > 1) // Ausgleichfaktor ist gleich 2 => prüfen ob wir einen LL-Fall haben, wenn ja, führen wir eine LL-Rotation durch
            {                //                                                                     andernfalls führen wir eine LR-Rotation durch.                                 
                if (balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1) // Ausgleichfaktor ist gleich -2 => prüfen ob wir einen RR-Fall haben, wenn ja, führen wir eine RR-Rotation durch
            {                       //                                                                     andernfalls führen wir eine RL-Rotation durch.
                if (balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        private Node Delete(int del_data, Node node)
        {
            /*nach dem Löschen müssen wir Balance() aufrufen,
             * um jeden der Knoten auf Ungleichgewichte im BAum zu überprüfen.
             * das Löschen finden rekursiv statt. */

            Node parent;
            if (node == null)
            {
                return null;
            }
            else if (search(del_data))
            {
                // das linke Kind
                if (del_data < node.Data)
                {
                    node.left = Delete(del_data, node.left);
                    if (balance_factor(node) == -2)
                    {
                        if (balance_factor(node.right) <= 0)
                        {
                            node = RotateRR(node);
                        }
                        else
                        {
                            node = RotateRL(node);
                        }
                    }
                }
                // das rechte Kind
                else if (del_data > node.Data)
                {
                    node.right = Delete(del_data, node.right);
                    if (balance_factor(node) == 2)
                    {
                        if (balance_factor(node.left) >= 0)
                        {
                            node = RotateLL(node);
                        }
                        else
                        {
                            node = RotateLR(node);
                        }
                    }
                }
                // das zu löschende Element ist gefunden
                else
                {
                    if (node.right != null)
                    {
                        parent = node.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        node.Data = parent.Data;
                        node.right = Delete(parent.Data, node.right);
                        if (balance_factor(node) == 2) // rebalancieren
                        {
                            if (balance_factor(node.left) >= 0)
                            {
                                node = RotateLL(node);
                            }
                            else { node = RotateLR(node); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return node.left;
                    }
                }
                return node;
            }
            // das zu löschende Element ist nicht vorhanden
            return null;
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;   // ist l > r, wenn ja : return l || wenn nein : return r
        }
        private int getHeight(Node current)
        {/*nimmet current als eine Node-Referenz und gibt ihre Höhe in dem Baum zurück.*/
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(Node current)
        {
            /* nimmt current als eine Node-Referenz, dies wird rekursiv die Höhen für beide Seiten erhalten und eine ganze Zahl zurückgeben*/
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }

        // die nächste 4 Methoden sind für die Drehung zuständig, sie nehmen parent als eine Node-Referenz und geben eine Pivot-Node mit der Drehung züruck
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
