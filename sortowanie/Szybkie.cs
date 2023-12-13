using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace sortowanie
{
    internal class Szybkie
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
        public static void QuickSort(int[] liczby, int left, int right)
        {
            start = DateTime.Now;
            int i = left;
            int j = right;
            int pivot = liczby[(left + right) / 2];
            while (i<j)
            {
                  while (liczby[i] < pivot) i++;
                  while (liczby[j] > pivot) j--;
                  if (i <= j)
                  {
                        int tmp = liczby[i];
                        liczby[i++] = liczby[j];
                        liczby[j--] = tmp;
                  }
            }
            if (left < j) QuickSort(liczby, left, j);
            if (i < right) QuickSort(liczby, i, right);
            stop = DateTime.Now;
        }
    }
}
