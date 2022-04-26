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
            multiSetUnsortedLinkedList.insert(3);
            multiSetUnsortedLinkedList.insert(3);
            multiSetUnsortedLinkedList.insert(4);
            setSortedLinkedList.print();
            multiSetUnsortedLinkedList.print();
            Console.ReadKey();
        }
    }
}
