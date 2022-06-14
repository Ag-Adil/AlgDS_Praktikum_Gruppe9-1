using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgDS_Praktikum_Gruppe9
{
    class HashTabQuadProb : HashTab , ISetUnsorted
    {
        public bool delete(int elem)
        {
            if (search(elem) == true)
            {
                for (int i = 0; i < quadProb.Length; i++)
                {
                    if (elem == quadProb[i])
                    {
                        quadProb[i] = 0;
                        quadProbVersuche[i] = 0;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine($"Der Wert {elem} kann nicht gelöscht werden, dar er nicht vorhanden ist!");
                return false;
            }
        }
        public bool insert(int elem)
        {
            try
            {
                if (search(elem) == false)
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
                else
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Die Hashtabelle ist für einen oder mehrere Werte voll");
                Program.TestHashTabQuadProb();
                throw;
            }
        }
        public void print()
        {
            for (int i = 0; i < quadProb.Length; i++)
            {
                Console.Write($"{quadProb[i],4}  |");
            }

            Console.WriteLine();
            for (int i = 0; i < (quadProb.Length * 7); i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();

            for (int i = 0; i < quadProb.Length; i++)
            {
                Console.Write($"{quadProbVersuche[i],4}  |");
            }
            Console.WriteLine();
        }
        public bool search(int elem)
        {
            bool gefunden = false;
            for (int i = 0; i < quadProb.Length; i++)
            {
                if (elem == quadProb[i])
                {
                    gefunden = true;
                    break;
                }
            }
            return gefunden;
        }
    }
}
