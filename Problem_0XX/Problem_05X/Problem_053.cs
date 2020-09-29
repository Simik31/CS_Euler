using CodeBase;
using System.Numerics;

/*
There are exactly ten ways of selecting three from five, 12345:
123, 124, 125, 134, 135, 145, 234, 235, 245, and 345
In combinatorics, we use the notation, (5 3)=10.
In general, (n r)=n!r!(n−r)!, where r≤n, n!=n×(n−1)×...×3×2×1, and 0!=1.
It is not until n=23, that a value exceeds one-million: (23 10)=1144066.
How many, not necessarily distinct, values of (n r) for 1≤n≤100, are greater than one-million?
*/

namespace cs_euler
{
    public class Problem_053 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int m = 1; m <= 100; m++) for (int n = 1; n <= m; n++) if (Combination.Biginteger(m, n).CompareTo(new BigInteger(1000000)) > 0) r++;
            return r;
        }
    }
}
