using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class EuclidExtendedAlgorithmSolution
    {
        private long x, y, d;

        public long X
        {
            get
            {
                return this.x;
            }
        }

        public long Y
        {
            get
            {
                return this.y;
            }
        }

        public long D
        {
            get
            {
                return this.d;
            }
        }

        public EuclidExtendedAlgorithmSolution(long x, long y, long d)
        {
            this.x = x;
            this.y = y;
            this.d = d;
        }
    }
}
