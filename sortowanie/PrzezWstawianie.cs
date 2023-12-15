using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class PrzezWstawianie
    {
    private DateTime start, stop;
    public Double Duration
    {
        get
        {
            if (start != null && stop != null)
            {
                return 1+ (stop - start).TotalMilliseconds;
            }
            else
            {
                return 0;
            }
        }
    }
  
        public  void InsertionSort(int[] liczby)
        {
            start = DateTime.Now;
            for (int i = 1; i < liczby.Length; ++i)
            {
                int current = liczby[i];
                int j = i - 1;

                while (j >= 0 && liczby[j] > current)
                {
                    liczby[j + 1] = liczby[j];
                    j = j - 1;
                }

                liczby[j + 1] = current;
            }
            stop = DateTime.Now;
        }
    }
}
