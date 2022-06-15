using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class BinSearchTree : ISetSorted
    {
        protected class Node
        {
            public Node left, right;
            public int Data { get; set; }

            public Node(int elem)
            {
                this.Data = elem;
                this.left = null;
                this.right = null;
            }
        }
        protected Node root;


        public bool search(int data)
        {
            //  Weiterleiten an private Search
            Node node = Search(data, root);
            if (node != null)
            {
                return true; // gefunden
            }
            else
            {
                return false; // elem ist nicht vorhanden
            }
        }

        protected Node Search(int data, Node node)
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
            else if (data < node.Data)
            {
                return Search(data, node.left);
            }
            else if (data > node.Data)
            {
                return Search(data, node.right);
            }
            else
            {
                return node;
            }
        }

        public bool insert(int data)
        {
            Node newItem = new Node(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                insert(newItem, root);
            }
            return true;

        }
        private void insert(Node current, Node node)
        {

            if (search(current.Data) == false) // neues Element wird hinzugefügt nur dann, 
            {                                  // wenn es im Baum nicht vorhanden ist 
                if (current.Data < node.Data) // Das linke Kind 
                {
                    if (node.left == null) // 1. Fall : das linke Kind ist leer
                    {
                        node.left = current;
                    }
                    else // 2. Fall : das linke Kind ist nicht leer, einfügen in das linke Kind
                    {
                        insert(current, node.left);
                    }
                }
                else // Das rechte Kind
                {
                    if (node.right == null) // 1. Fall : das rechte Kind ist leer
                    {
                        node.right = current;
                    }
                    else // 2. Fall : das rechte Kind ist nicht leer, einfüge in das rechte Kind
                    {
                        insert(current, node.right);
                    }
                }
            }
        }

        public void print()
        {
            if (root == null)
            {
                Console.WriteLine("Baum ist leer");
                return;
            }
            print(root, 0);
            Console.WriteLine();
        }
        private void print(Node node, int space)
        {
            space += 10;
            // Variable space hilft dabei, den Baum übersichtlich auszugeben
            if (node != null)
            {
                print(node.right, space);
                for (int i = 10; i < space; i++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine("({0}) ", node.Data);
                print(node.left, space);
            }
        }
        private int FindMax(Node node) // Hilfsmethode für Delete
        {
            // node besitzt zwei Nachfolger
            // Ersetze node durch das größte Element im linken Teilbaum 
            if (node.right == null)
            {
                return node.Data;
            }
            else
            {
                return FindMax(node.right);
            }
        }
        public bool delete(int del_data)
        {
            if (Delete(del_data, root) != null)
                return true;
            else
                return false;
        }
        private Node Delete(int del_data, Node node)
        {
            if (root == null || !search(del_data))// Baum ist leer oder das zu löschende Element ist nicht vorhanden
            {
                return null;
            }
            else // das zu löschende Element ist vorhanden
            {
                if (del_data < node.Data) // das linke Kind
                {
                    node.left = Delete(del_data, node.left);
                }
                else if (del_data > node.Data) // das rechte Kind
                {
                    node.right = Delete(del_data, node.right);
                }
                else // das zu löschende Element ist gefunden
                {
                    if (node.left != null && node.right != null) //es gibt rechten und linken Nachfolger
                    {
                        node.Data = FindMax(node.left);

                        node.left = Delete(del_data, node.left); // Nach Ersatz von node.Elem mit FindMax, muss FindMax-Wert im linken Baum gelöscht werden
                    }

                    else if (node.left != null) // es gibt keinen rechten Nachfolger
                    {
                        node = node.left;
                    }
                    else // es gibt keinen linken Nachfolger
                        node = node.right;
                }
            }
            return node;
        }


    }
}
