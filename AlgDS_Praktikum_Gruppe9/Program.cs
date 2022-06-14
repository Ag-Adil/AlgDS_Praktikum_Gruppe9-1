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
            // Implementierung einer abfrage für die Bedienung der Software möglich über switch case etc -> muss vervollständigt werden 
            Console.WriteLine("Prakikum Gruppe 9");
            Console.WriteLine();
            Programmstart();
        }
        private static void Programmstart()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: MultiSetUnsorted \n2: SetUnsorted \n3: MultiSetSorted \n4: SetSorted \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestMultiSetUnsorted();
                    break;
                case 2:
                    TestSetUnsorted();
                    break;
                case 3:
                    TestMultiSetSorted();
                    break;
                case 4:
                    TestSetSorted();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void TestSetSorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestSetSortedLinkedList();
                    break;
                default:
                    break;
            }
        }

        private static void TestMultiSetSorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestMultiSetSortedLinkedList();
                    break;
                default:
                    break;
            }
        }

        

        private static void TestSetUnsorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: HashTabSepChain \n3: HashTabQuadProb \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestSetUnsortedLinkedList();
                    break;
                case 2:
                    TestHashTabSepChain();
                    break;
                case 3:
                    TestHashTabQuadProb();
                    break;
                default:
                    break;
            }
        }

        private static void TestMultiSetUnsorted()
        {
            Console.Write("Welche Funktion möchten Sie bedienen \n1: LinkedList \n2: Array \nIhre Eingabe: ");
            string eingabe = Console.ReadLine();
            int auswahl = Convert.ToInt32(eingabe);
            Console.Clear();
            switch (auswahl)
            {
                case 1:
                    TestMultiSetUnsortedLinkedList();
                    break;
                default:
                    break;
            }
        }
        public static void TestMultiSetSortedLinkedList()
        {
            MultiSetSortedLinkedList multiSetSortedLinkedList = new MultiSetSortedLinkedList();
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Wählen Sie eine Funktion: \n1: Einfügen\n2: Löschen\n3: Suchen\n4: Ausgeben \n5: Automatische Liste Generieren \n6: Zurück zum Hauptmenü \nIhre Auswahl: ");
                string eingabe = Console.ReadLine();
                int auswahl = Convert.ToInt32(eingabe);
                Console.Clear();
                switch (auswahl)
                {
                    case 1:
                        Console.Write("Welchen Wert wollen Sie Einfügen: ");
                        string eingabe1 = Console.ReadLine();
                        int auswahl1 = Convert.ToInt32(eingabe1);
                        multiSetSortedLinkedList.insert(auswahl1);
                        break;
                    case 2:
                        Console.Write("Welchen Wert wollen Sie Löschen: ");
                        string eingabe2 = Console.ReadLine();
                        int auswahl2 = Convert.ToInt32(eingabe2);
                        multiSetSortedLinkedList.delete(auswahl2);
                        break;
                    case 3:
                        Console.Write("Welchen Wert wollen Sie Suchen: ");
                        string eingabe3 = Console.ReadLine();
                        int auswahl3 = Convert.ToInt32(eingabe3);
                        Console.WriteLine(multiSetSortedLinkedList.search(auswahl3));
                        break;
                    case 4:
                        multiSetSortedLinkedList.print();
                        break;
                    case 5:
                        Console.Write("Wie Lange soll die Generierte Liste sein: ");
                        string eingabe5 = Console.ReadLine();
                        int auswahl5 = Convert.ToInt32(eingabe5);
                        Random rnd = new Random();
                        for (int i = 0; i < auswahl5; i++)
                        {
                            multiSetSortedLinkedList.insert(rnd.Next(0, 9));
                        }
                        break;
                    case 6:
                        Programmstart();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void TestSetSortedLinkedList()
        {
            SetSortedLinkedList setSortedLinkedList = new SetSortedLinkedList();
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Wählen Sie eine Funktion: \n1: Einfügen\n2: Löschen\n3: Suchen\n4: Ausgeben \n5: Automatische Liste Generieren \n6: Zurück zum Hauptmenü \nIhre Auswahl: ");
                string eingabe = Console.ReadLine();
                int auswahl = Convert.ToInt32(eingabe);
                Console.Clear();
                switch (auswahl)
                {
                    case 1:
                        Console.Write("Welchen Wert wollen Sie Einfügen: ");
                        string eingabe1 = Console.ReadLine();
                        int auswahl1 = Convert.ToInt32(eingabe1);
                        setSortedLinkedList.insert(auswahl1);
                        break;
                    case 2:
                        Console.Write("Welchen Wert wollen Sie Löschen: ");
                        string eingabe2 = Console.ReadLine();
                        int auswahl2 = Convert.ToInt32(eingabe2);
                        setSortedLinkedList.delete(auswahl2);
                        break;
                    case 3:
                        Console.Write("Welchen Wert wollen Sie Suchen: ");
                        string eingabe3 = Console.ReadLine();
                        int auswahl3 = Convert.ToInt32(eingabe3);
                        Console.WriteLine(setSortedLinkedList.search(auswahl3));
                        break;
                    case 4:
                        setSortedLinkedList.print();
                        break;
                    case 5:
                        Console.Write("Wie Lange soll die Generierte Liste sein: ");
                        string eingabe5 = Console.ReadLine();
                        int auswahl5 = Convert.ToInt32(eingabe5);
                        Random rnd = new Random();
                        for (int i = 0; i < auswahl5; i++)
                        {
                            setSortedLinkedList.insert(rnd.Next(0, 9));
                        }
                        break;
                    case 6:
                        Programmstart();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void TestSetUnsortedLinkedList()
        {
            SetUnsortedLinkedList setUnsortedLinkedList = new SetUnsortedLinkedList();
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Wählen Sie eine Funktion: \n1: Einfügen\n2: Löschen\n3: Suchen\n4: Ausgeben \n5: Automatische Liste Generieren \n6: Zurück zum Hauptmenü \nIhre Auswahl: ");
                string eingabe = Console.ReadLine();
                int auswahl = Convert.ToInt32(eingabe);
                Console.Clear();
                switch (auswahl)
                {
                    case 1:
                        Console.Write("Welchen Wert wollen Sie Einfügen: ");
                        string eingabe1 = Console.ReadLine();
                        int auswahl1 = Convert.ToInt32(eingabe1);
                        setUnsortedLinkedList.insert(auswahl1);
                        break;
                    case 2:
                        Console.Write("Welchen Wert wollen Sie Löschen: ");
                        string eingabe2 = Console.ReadLine();
                        int auswahl2 = Convert.ToInt32(eingabe2);
                        setUnsortedLinkedList.delete(auswahl2);
                        break;
                    case 3:
                        Console.Write("Welchen Wert wollen Sie Suchen: ");
                        string eingabe3 = Console.ReadLine();
                        int auswahl3 = Convert.ToInt32(eingabe3);
                        Console.WriteLine(setUnsortedLinkedList.search(auswahl3));
                        break;
                    case 4:
                        setUnsortedLinkedList.print();
                        break;
                    case 5:
                        Console.Write("Wie Lange soll die Generierte Liste sein: ");
                        string eingabe5 = Console.ReadLine();
                        int auswahl5 = Convert.ToInt32(eingabe5);
                        Random rnd = new Random();
                        for (int i = 0; i < auswahl5; i++)
                        {
                            setUnsortedLinkedList.insert(rnd.Next(0, 9));
                        }
                        break;
                    case 6:
                        Programmstart();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void TestMultiSetUnsortedLinkedList()
        {
            MultiSetUnsortedLinkedList multiSetUnsortedLinkedList = new MultiSetUnsortedLinkedList();
            bool repeat = true;
            while (repeat)
            {
                Console.Write("Wählen Sie eine Funktion: \n1: Einfügen\n2: Löschen\n3: Suchen\n4: Ausgeben \n5: Automatische Liste Generieren \n6: Zurück zum Hauptmenü \nIhre Auswahl: ");
                string eingabe = Console.ReadLine();
                int auswahl = Convert.ToInt32(eingabe);
                Console.Clear();
                switch (auswahl)
                {
                    case 1:
                        Console.Write("Welchen Wert wollen Sie Einfügen: ");
                        string eingabe1 = Console.ReadLine();
                        int auswahl1 = Convert.ToInt32(eingabe1);
                        multiSetUnsortedLinkedList.insert(auswahl1);
                        break;
                    case 2:
                        Console.Write("Welchen Wert wollen Sie Löschen: ");
                        string eingabe2 = Console.ReadLine();
                        int auswahl2 = Convert.ToInt32(eingabe2);
                        multiSetUnsortedLinkedList.delete(auswahl2);
                        break;
                    case 3:
                        Console.Write("Welchen Wert wollen Sie Suchen: ");
                        string eingabe3 = Console.ReadLine();
                        int auswahl3 = Convert.ToInt32(eingabe3);
                        Console.WriteLine(multiSetUnsortedLinkedList.search(auswahl3));
                        break;
                    case 4:
                        multiSetUnsortedLinkedList.print();
                        break;
                    case 5:
                        Console.Write("Wie Lange soll die Generierte Liste sein: ");
                        string eingabe5 = Console.ReadLine();
                        int auswahl5 = Convert.ToInt32(eingabe5);
                        Random rnd = new Random();
                        for (int i = 0; i < auswahl5; i++)
                        {
                            multiSetUnsortedLinkedList.insert(rnd.Next(0, 9));
                        }
                        break;
                    case 6:
                        Programmstart();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void TestHashTabSepChain()
        {
            HashTabSepChain hashTabSepChain = new HashTabSepChain();
            hashTabSepChain.hilfsfunction();
            hashTabSepChain.insert(12);
            hashTabSepChain.insert(56);
            hashTabSepChain.insert(47);
            hashTabSepChain.insert(19);
            hashTabSepChain.insert(89);
            hashTabSepChain.insert(31);
            hashTabSepChain.insert(24);
            hashTabSepChain.insert(79);
            hashTabSepChain.print();
            Console.WriteLine(hashTabSepChain.search(32));
            hashTabSepChain.delete(31);
            hashTabSepChain.print();
        }
        public static void TestHashTabQuadProb()
        {
            HashTabQuadProb hashTabQuadProb = new HashTabQuadProb();
            hashTabQuadProb.insert(12);
            hashTabQuadProb.insert(56);
            hashTabQuadProb.insert(47);
            hashTabQuadProb.insert(89);
            hashTabQuadProb.insert(31);
            hashTabQuadProb.insert(82);
            hashTabQuadProb.insert(10);
            hashTabQuadProb.insert(11);
            Console.WriteLine(hashTabQuadProb.search(56));
            hashTabQuadProb.print();
        }
    }
}
