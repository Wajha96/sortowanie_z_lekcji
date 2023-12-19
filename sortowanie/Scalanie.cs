using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class Scalanie : Czas
    {
        public void MergingSortMian(int[] liczby, int left, int right)
        {
            int[] dos = new int[liczby.Length];
            for (int k = 0; k < liczby.Length; k++)
            {
                dos[k] = liczby[k];
            }
                StartCount();
                merging_sort(dos, left, right);
                StopCount();
        }
           public void merge(int[] dos, int left, int mid, int right)
            {
                int i = left, j = mid + 1;

                int[] pom = new int[dos.Length];

                for (int m = left; m < dos.Length; m++)
                {
                    pom[m] = dos[m];
                }

                for (int k = left; k <= right; k++)
                    if (i <= mid)
                    {
                        if (j <= right)
                        {
                            if (pom[j] < pom[i])
                            {
                                dos[k] = pom[j++];
                            }
                            else
                            {
                                dos[k] = pom[i++];
                            }
                        }
                        else
                        {
                            dos[k] = pom[i++];
                        }
                    }
                    else
                    {
                        dos[k] = pom[j++];
                    }
            }
            public void merging_sort(int[] dos, int left, int right)
            {

                if (right <= left)
                {
                    return;
                }

                int srodek = (right + left) / 2;


                    merging_sort(dos, left, srodek);
                    merging_sort(dos, srodek + 1, right);


                merge(dos, left, srodek, right);
            }
        }
}
