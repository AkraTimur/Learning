using System;
using System.Collections.Generic;
using System.Text;

namespace arrayContains
{
    internal class Finder
    {
        public static bool FindContains(string[] array,string whatFind)
        {
            int findCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals( whatFind)) findCount++;
                
            }
            if (findCount == 0) return false;
            else return true;
        }
    }
}
