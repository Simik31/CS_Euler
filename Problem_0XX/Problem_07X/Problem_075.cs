using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

/*
It turns out that 12 cm is the smallest length of wire that can be bent to form an integer sided right angle triangle in exactly one way, but there are many more examples.

12 cm: (3,4,5)
24 cm: (6,8,10)
30 cm: (5,12,13)
36 cm: (9,12,15)
40 cm: (8,15,17)
48 cm: (12,16,20)

In contrast, some lengths of wire, like 20 cm, cannot be bent to form an integer sided right angle triangle, and other lengths allow more than one solution to be found; for example, using 120 cm it is possible to form exactly three different integer sided right angle triangles.
120 cm: (30,40,50), (20,48,52), (24,45,51)
Given that L is the length of the wire, for how many values of L ≤ 1,500,000 can exactly one integer sided right angle triangle be formed?
*/

namespace cs_euler
{
    class Problem_075 : IProblem
    {
        public long Run()
        {
            Console.WriteLine();
            int max_l = 1_500_000, max_a = max_l / 3, max_b = max_l / 2;
            List<int> lengths = new List<int>(), results = new List<int>();
            List<double> square = new List<double>();
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i <= max_b; i++) square.Add(Math.Pow(i, 2));
            sw.Start();
            for (int a = 3; a <= max_a; a++)
            {
                double a2 = square[a];
                for (int b = a + 1; b <= max_b; b++)
                {
                    double c = Math.Sqrt(a2 + square[b]);
                    if (c % 1 == 0.0 && c > b) lengths.Add(a + b + (int)c);
                }
                Console.WriteLine("Done: {0, 7:###,##0}/{1, 7:###,##0}", a, max_a);
            }
            Console.WriteLine("Done triplets Time: {0, 9:#,###,##0}ms", sw.ElapsedMilliseconds);
            sw.Restart();
            Console.WriteLine("Filtering results");
            foreach (int len in lengths) if (lengths.IndexOf(len) == lengths.LastIndexOf(len) && len <= max_l) results.Add(len);
            Console.WriteLine("Filtering  Time: {0, 9:#,###,##0}ms",sw.ElapsedMilliseconds);
            sw.Stop();
            return results.Count;
        }
    }
}