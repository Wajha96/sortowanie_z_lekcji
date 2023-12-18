using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace sortowanie
{
    internal class PrzezWybor : Czas
    {
      
        public void BySelection(int[] liczby)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            StartCount();
            for (int i = 0; i < liczby.Length - 1; i++)
            {

                int min_idx = i;
                for (int j = i + 1; j < liczby.Length; j++)
                    if (dos[j] < dos[min_idx])
                        min_idx = j;


                int temp = dos[min_idx];
                dos[min_idx] = dos[i];
                dos[i] = temp;
            }
            StopCount();
        }
    }
}
