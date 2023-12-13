using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class PrzezWybor
    {
        private static DateTime start, stop;
        public Double Duration
        {
            get
            {
                if (start == null && stop != null)
                {
                    return (stop - start).TotalMilliseconds;
                }
                else
                {
                    return 0;
                }
            }
        }
        public static void BySelection(int[] liczby)
        {
            start = DateTime.Now;
            for (int i = 0; i < liczby.Length - 1; i++)
            {

                int min_idx = i;
                for (int j = i + 1; j < liczby.Length; j++)
                    if (liczby[j] < liczby[min_idx])
                        min_idx = j;


                int temp = liczby[min_idx];
                liczby[min_idx] = liczby[i];
                liczby[i] = temp;
            }
            stop = DateTime.Now;
        }
    }
}
