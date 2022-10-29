using System;

namespace LinqApp4
{
    public class Program
    {
        static  Random random => new Random();

        static double GetRandomDouble(int max) => max * random.NextDouble();

        static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}");

        static void Main(string[] args)
        {
            var value = Program.GetRandomDouble(100);
            Program.PrintValue(value);


            // part 2

            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };

            IEnumerable<int> result =
                from v in values
                where v < 37
                orderby -v
                select v;

            var result2 = values.Where(v => v < 37).OrderBy(v => -v);
            var result3 = values.Where(v => v < 37).OrderByDescending(v => v);

        }
    }
}
