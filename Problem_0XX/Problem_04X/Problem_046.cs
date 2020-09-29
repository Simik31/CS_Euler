using System;
using System.Collections.Generic;
using CodeBase;

/*
It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.
9 = 7 + 2×1^2
15 = 7 + 2×2^2
21 = 3 + 2×3^2
25 = 7 + 2×3^2
27 = 19 + 2×2^2
33 = 31 + 2×1^2
It turns out that the conjecture was false.
What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?
*/

namespace cs_euler
{
    public class Problem_046 : IProblem
    {
        public long Run()
        {
            List<long> p = new List<long> { 2 };
            for (int n = 3; ; n += 2)
            {
                p.AddRange(Prime.GetInRange(p[^1], n));
                for (int i = 0; i < p.Count; i++)
                {
                    if (Math.Sqrt((n - p[i]) / 2) % 1 == 0) break;
                    if (i == p.Count - 1) return n;
                }
            }
        }
    }
}
