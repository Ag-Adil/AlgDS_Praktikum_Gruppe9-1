using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class HashTabSepChain : HashTab , ISetUnsorted
    {
        public bool insert(int elem)
        {
            int hashwert = Hashfunction(elem);
            for (int i = 0; i < setUnsortedLinkedListArray.Length; i++)
            {
                if (i == hashwert)
                {
                    setUnsortedLinkedListArray[i].insert(elem);
                }
            }
            return true;
        }
        public bool search(int elem)
        {
            int hashwert = Hashfunction(elem);
            if (setUnsortedLinkedListArray[hashwert].search(elem) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool delete(int elem)
        {
            int hashwert = Hashfunction(elem);
            if (search(elem) == true)
            {
                setUnsortedLinkedListArray[hashwert].delete(elem);
                return true;
            }
            else
            {
                return false;
            }
        }
        

        public void print()
        {
            // ToDo -> eigene print Function schreiben -> schönere Anordnung -> möglicherweise Tabelle
            for (int i = 0; i < setUnsortedLinkedListArray.Length - 1; i++)
            {
                setUnsortedLinkedListArray[i].print();
            }
        }
    }
}
