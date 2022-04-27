using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementierung einer abfrage für die Bedienung der Software möglich über switch case etc 
            Console.WriteLine("Prakikum Gruppe 9");
            Console.Write("Welche Funktion möchten Sie bedienen \n1: MultiSetUnsorted \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            switch (auswahl)
            {
                case 1:
                    TestMultiSetUnsortedLinkedList();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            TestMultiSetUnsortedLinkedList();
            TestSetUnsortedLinkedList();
            TestSetSortedLinkedList();
            Console.ReadKey();
        }

        public static void TestSetSortedLinkedList()
        {
            Console.WriteLine("SetSortedLinkedList:");
            SetSortedLinkedList setSortedLinkedList = new SetSortedLinkedList();
            setSortedLinkedList.insert(7);
            setSortedLinkedList.insert(11);
            setSortedLinkedList.insert(3);
            setSortedLinkedList.insert(4);
            setSortedLinkedList.insert(9);
            setSortedLinkedList.insert(10);
            setSortedLinkedList.print();
        }

        public static void TestMultiSetUnsortedLinkedList()
        {
            MultiSetUnsortedLinkedList multiSetUnsortedLinkedList = new MultiSetUnsortedLinkedList();
            multiSetUnsortedLinkedList.insert(3);
            multiSetUnsortedLinkedList.insert(5);
            multiSetUnsortedLinkedList.insert(4);
            multiSetUnsortedLinkedList.insert(4);
            multiSetUnsortedLinkedList.insert(2);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(5);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(4);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(3);
            multiSetUnsortedLinkedList.print();
            multiSetUnsortedLinkedList.delete(2);
            multiSetUnsortedLinkedList.print();
        }

        public static void TestSetUnsortedLinkedList()
        {
            SetUnsortedLinkedList setUnsortedLinkedList = new SetUnsortedLinkedList();
            setUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.insert(3);
            setUnsortedLinkedList.insert(2);
            setUnsortedLinkedList.print();
            setUnsortedLinkedList.delete(4);
            setUnsortedLinkedList.print();
        }
    }
}
