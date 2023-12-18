using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortowanie
{
    internal class Czas
    {
        private DateTime start, stop;
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

        public void StartCount()
        {
            start = DateTime.Now;
        }

        public void StopCount()
        {
            stop = DateTime.Now;
        }
    }
}
