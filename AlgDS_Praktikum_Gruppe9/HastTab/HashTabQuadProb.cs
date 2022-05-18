using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class HashTabQuadProb : HashTab , ISetUnsorted
    {
        // ToDo: Verdopplungen unterbinden, delete funktion hinzufügen
        
        public bool delete(int elem)
        {
            if (search(elem))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool insert(int elem)
        {
            int counter = 0;
            int hashwert = HashIndex(elem);
            if (quadProbVersuche[hashwert] != 0)
            {
                while (quadProbVersuche[Hashfunction1(elem, counter)] != 0)
                {
                    counter++;
                }
                quadProbVersuche[Hashfunction1(elem, counter)] = counter + 1;
                quadProb[Hashfunction1(elem, counter)] = elem;
            }
            else
            {
                quadProbVersuche[hashwert] += 1;
                quadProb[hashwert] = elem;
            }
            return true;


        }
        public void print()
        {
            for (int i = 0; i < quadProb.Length; i++)
            {
                Console.Write($"{quadProb[i],4}");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < quadProb.Length; i++)
            {
                Console.Write($"{quadProbVersuche[i],4}");
            }

        }
        public bool search(int elem)
        {
            int index = HashIndex(elem);
            int counter = 0;
            while (counter < quadProb.Length)
            {
                if (elem == quadProb[index + Convert.ToInt32((c1 * counter) + (c2 * (counter * counter)))])
                {
                    return true;
                }
                else if (quadProbVersuche[Hashfunction1(elem, counter)] == 0 || quadProb[index] == 0)
                {
                    return false;
                }
                counter++;
            }
            return false;
        }

        
    }
}
