using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class Babelkowe
    {
        private static DateTime start, stop;
        public Double Duration
        {
            get
            {
                if (start != null && stop != null)
                {
                    return (stop - start).TotalMilliseconds;
                }
                else
                {
                    return 0;
                }
            }
        }
        public void BubbleSort(int[] liczby)
        {
            start = DateTime.Now;
            for (int i = 0; i < liczby.Length - 1; i++)
            {

                for (int j = 0; j < liczby.Length - i - 1; j++)
                    if (liczby[j] > liczby[j + 1])
                    {
                        int temp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = temp;

                    }
            }
            stop = DateTime.Now;

        }
    }
}
