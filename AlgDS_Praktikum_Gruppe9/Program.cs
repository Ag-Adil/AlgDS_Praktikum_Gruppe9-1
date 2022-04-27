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
            //MultiSetUnsortedLinkedList multiSetUnsortedLinkedList = new MultiSetUnsortedLinkedList();
            TestMultiSetUnsortedLinkedList();
            //SetSortedLinkedList setSortedLinkedList = new SetSortedLinkedList();
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
