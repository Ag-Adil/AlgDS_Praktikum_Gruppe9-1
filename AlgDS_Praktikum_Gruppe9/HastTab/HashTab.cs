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
        protected static int[] quadProb = new int[12];
        protected static int[] quadProbVersuche = new int[quadProb.Length];
        protected static double c1 = 0.5;
        protected static double c2 = 1.5;

        protected int Hashfunction(int wert)
        {
            int hashwert = 0;
            hashwert = (3 + (3 * wert)) % setUnsortedLinkedListArray.Length;
            return hashwert;
        }

        protected int Hashfunction1(int wert, int counter)
        {
            // double c1 = 0.5;
            // double c2 = 1.5;
            double hashwert = Convert.ToDouble((2 + (3 * wert)) % quadProb.Length) + (c1 * counter) + (c2 * (counter * counter));
            int hashwertnew = Convert.ToInt32(hashwert);
            while (hashwertnew > quadProb.Length)
            {
                hashwertnew -= quadProb.Length;
            }
            return hashwertnew;
        }
        protected int HashIndex(int wert)
        {
            double hashwert = Convert.ToDouble((2 + (3 * wert)) % quadProb.Length);
            int hashwertnew = Convert.ToInt32(hashwert);
            return hashwertnew;

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
