using CodeBase;
using System;

/*
n! means n × (n − 1) × ... × 3 × 2 × 1
For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
Find the sum of the digits in the number 100!
*/

namespace cs_euler
{
    public class Problem_020 : IProblem
    {
        public long Run()
        {
            long s = 0;
            char[] v = Factorial.String(100).ToCharArray();
            foreach (char c in v) s += c - '0';
            return s;
        }
    }
}
