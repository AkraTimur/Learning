using System;
using System.Collections.Generic;
using System.Text;

namespace LearnApp1
{
    public static class Extension
    {
        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }
    }
}
