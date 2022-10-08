using System;

namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> res = new List<int>() { 3, 8, 7, 6, 9, 6, 2 };
            int ans = res.Skip(4).Sum();
            int ans1 = res.Skip(5).Sum();
            int ans2 =Enumerable.Range(10, 3721).Count();
            Console.WriteLine(ans);
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);

            Console.WriteLine("part two");
            AddSubtract a = new AddSubtract() { Value = 5 }
            .Add(5)
            .Subtract(3)
            .Add(9)
            .Subtract(12); Console.WriteLine($"Result: {a.Value}");
        }
    }
}