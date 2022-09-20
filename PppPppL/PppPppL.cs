using System;
using System.Collections.Generic;
using System.Text;

namespace PppPppL
{
   public static class PppPppL
    {
        public static void PppPppLl(List<string> a)
        {
            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);
            a.RemoveAt(2);

            if (a.Contains("three"))
            {
                a.Add("four");
            }
            if (a.IndexOf("four") != 4)
            {
                a.Add(fourth);
            }
            if (a.Contains("two"))
            {
                a.Add(twopointtwo);
            }
            foreach (string element in a)
            {
                Console.WriteLine(element);
            }
        }
    }
}
