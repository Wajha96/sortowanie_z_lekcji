using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace sortowanie
{
    internal class Szybkie : Czas
    {
        public void QuickSort(int[] liczby, int left, int right)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
            StartCount();
            QuickSortv2(dos, left, right);
            StopCount();
        }
        public void QuickSortv2(int[] szybkieliczby, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = szybkieliczby[(left + right) / 2];
            while (i<j)
            {
                  while (szybkieliczby[i] < pivot) i++;
                  while (szybkieliczby[j] > pivot) j--;
                  if (i <= j)
                  {
                        int tmp = szybkieliczby[i];
                        szybkieliczby[i++] = szybkieliczby[j];
                        szybkieliczby[j--] = tmp;
                  }
            }
            if (left < j) QuickSortv2(szybkieliczby, left, j);
            if (i < right) QuickSortv2(szybkieliczby, i, right);
        }
    }
}
