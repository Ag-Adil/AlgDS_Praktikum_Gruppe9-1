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
            MultiSetUnsortedLinkedList multiSetUnsortedLinkedList = new MultiSetUnsortedLinkedList();
            SetSortedLinkedList setSortedLinkedList = new SetSortedLinkedList();
            SetUnsortedLinkedList setUnsortedLinkedList = new SetUnsortedLinkedList();
            setUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.insert(3);
            setUnsortedLinkedList.insert(2);

            multiSetUnsortedLinkedList.insert(3);
            multiSetUnsortedLinkedList.insert(3);
            multiSetUnsortedLinkedList.insert(4);
            setUnsortedLinkedList.print();
            setSortedLinkedList.print();
            multiSetUnsortedLinkedList.print();
            Console.ReadKey();
        }
    }
}
