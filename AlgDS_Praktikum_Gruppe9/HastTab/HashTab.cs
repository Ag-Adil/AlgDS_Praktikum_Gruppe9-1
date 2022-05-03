using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    abstract class HashTab
    {
        protected SetUnsortedLinkedList[] setUnsortedLinkedListArray = new SetUnsortedLinkedList[8];

        protected int Hashfunction(int wert)
        {
            int hashwert = 0;
            hashwert = (3 + (3 * wert)) % setUnsortedLinkedListArray.Length;
            return hashwert;
        }
        public void hilfsfunction()
        {
            for (int i = 0; i < setUnsortedLinkedListArray.Length; i++)
            {
                setUnsortedLinkedListArray[i] = new SetUnsortedLinkedList();
            }
            
        }

        

    }
}
