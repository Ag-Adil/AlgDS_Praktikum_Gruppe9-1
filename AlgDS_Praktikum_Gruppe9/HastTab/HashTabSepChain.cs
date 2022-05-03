using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    // Interface Einbauen
    class HashTabSepChain : HashTab //, ISetUnsorted
    {
        public void insert(int elem)
        {
            int hashwert = Hashfunction(elem);
            for (int i = 0; i < setUnsortedLinkedListArray.Length; i++)
            {
                if (i == hashwert)
                {
                    setUnsortedLinkedListArray[i].insert(elem);
                }
            }
        }

        public void print()
        {
            // ToDo -> eigene print Function schreiben -> schönere Anordnung -> möglicherweise Tabelle
            for (int i = 0; i < setUnsortedLinkedListArray.Length - 1; i++)
            {
                setUnsortedLinkedListArray[i].print();
                Console.WriteLine();
            }
        }
    }
}
