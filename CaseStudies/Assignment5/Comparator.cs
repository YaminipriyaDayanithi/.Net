using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class NoOfReadsComparator : IComparer<Story>
    {
        public int Compare(Story x, Story y)
        {
            return x.NoOfReads.CompareTo(y.NoOfReads);
        }
    }
}
