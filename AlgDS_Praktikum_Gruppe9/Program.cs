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
                        hashTabSepChain.insert(auswahl1);
                        break;
                    case 2:
                        Console.Write("Welchen Wert wollen Sie Löschen: ");
                        string eingabe2 = Console.ReadLine();
                        int auswahl2 = Convert.ToInt32(eingabe2);
                        hashTabSepChain.delete(auswahl2);
                        break;
                    case 3:
                        Console.Write("Welchen Wert wollen Sie Suchen: ");
                        string eingabe3 = Console.ReadLine();
                        int auswahl3 = Convert.ToInt32(eingabe3);
                        Console.WriteLine(hashTabSepChain.search(auswahl3));
                        break;
                    case 4:
                        hashTabSepChain.print();
                        break;
                    case 5:
                        Console.Write("Wie Lange soll die Generierte Liste sein: ");
                        string eingabe5 = Console.ReadLine();
                        int auswahl5 = Convert.ToInt32(eingabe5);
                        Random rnd = new Random();
                        for (int i = 0; i < auswahl5; i++)
                        {
                            int zufall = rnd.Next(0, 99);
                            hashTabSepChain.insert(zufall);
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
        public static void TestHashTabQuadProb()
        {
            HashTabQuadProb hashTabQuadProb = new HashTabQuadProb();
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
                        hashTabQuadProb.insert(auswahl1);
                        break;
                    case 2:
                        Console.Write("Welchen Wert wollen Sie Löschen: ");
                        string eingabe2 = Console.ReadLine();
                        int auswahl2 = Convert.ToInt32(eingabe2);
                        hashTabQuadProb.delete(auswahl2);
                        break;
                    case 3:
                        Console.Write("Welchen Wert wollen Sie Suchen: ");
                        string eingabe3 = Console.ReadLine();
                        int auswahl3 = Convert.ToInt32(eingabe3);
                        Console.WriteLine(hashTabQuadProb.search(auswahl3));
                        break;
                    case 4:
                        hashTabQuadProb.print();
                        break;
                    case 5:
                        Console.Write("Wie Lange soll die Generierte Liste sein: ");
                        string eingabe5 = Console.ReadLine();
                        int auswahl5 = Convert.ToInt32(eingabe5);
                        Random rnd = new Random();
                        for (int i = 0; i < auswahl5; i++)
                        {
                            int zufall = rnd.Next(0, 99);
                            hashTabQuadProb.insert(zufall);
                            Console.WriteLine("JST " + zufall);
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
    }
}
