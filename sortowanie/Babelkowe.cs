using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class Babelkowe : Czas
    {
        public void BubbleSort(int[] liczby)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            StartCount();
            for (int i = 0; i < liczby.Length - 1; i++)
            {

                for (int j = 0; j < liczby.Length - i - 1; j++)
                    if (dos[j] > dos[j + 1])
                    {
                        int temp = dos[j];
                        dos[j] = dos[j + 1];
                        dos[j + 1] = temp;
                    }
            }
            StopCount();

        }
    }
}
