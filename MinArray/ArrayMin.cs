using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MinArray
{
    public static class ArrayMin
    {
        public static object Min (Array array)
        {

            IComparable min = (IComparable)array.GetValue(0);
            foreach (var e in array)
                if (min.CompareTo(e) > 0)
                    min = (IComparable)e;
            return min;

        }
    }
}
