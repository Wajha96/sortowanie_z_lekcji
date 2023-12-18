using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class PrzezWstawianie : Czas
    {
        public  void InsertionSort(int[] liczby)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            StartCount();
            for (int i = 1; i < liczby.Length; ++i)
            {
                int current = dos[i];
                int j = i - 1;

                while (j >= 0 && dos[j] > current)
                {
                    dos[j + 1] = dos[j];
                    j = j - 1;
                }

                dos[j + 1] = current;
            }
            StopCount();
        }
    }
}
