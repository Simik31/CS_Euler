using System.Collections.Generic;
using CodeBase;

/*
The number 145 is well known for the property that the sum of the factorial of its digits is equal to 145:
1! + 4! + 5! = 1 + 24 + 120 = 145
Perhaps less well known is 169, in that it produces the longest chain of numbers that link back to 169; it turns out that there are only three such loops that exist:
169 → 363601 → 1454 → 169
871 → 45361 → 871
872 → 45362 → 872
It is not difficult to prove that EVERY starting number will eventually get stuck in a loop. For example,
69 → 363600 → 1454 → 169 → 363601 (→ 1454)
78 → 45360 → 871 → 45361 (→ 871)
540 → 145 (→ 145)
Starting with 69 produces a chain of five non-repeating terms, but the longest non-repeating chain with a starting number below one million is sixty terms.
How many chains, with a starting number below one million, contain exactly sixty non-repeating terms?
*/

namespace cs_euler
{
    public class Problem_074 : IProblem
    {
        public long Run()
        {
            long l = 1000000;
            long r = 0;
            long[] h = new long[l + 1];
            h[169] = 3;
            h[363601] = 3;
            h[1454] = 3;
            h[871] = 2;
            h[45361] = 2;
            h[872] = 2;
            h[45362] = 2;

            for (int i = 1; i <= l; i++)
            {
                long n = i;
                long c = 0;
                List<long> s = new List<long>{ 0 };

                while (s[^1] != n)
                {
                    s.Add(n);
                    long o = 0;
                    while (n > 0)
                    {
                        o += Factorial.Long(n % 10);
                        n /= 10;
                    }
                    n = o;
                    c++;

                    if (n <= l && h[n] > 0)
                    {
                        c += h[n];
                        break;
                    }
                }
                if (c == 60) r++;

                for (int j = 1; j < s.Count; j++)
                {
                    if (s[j] <= l) h[s[j]] = c;
                    c--;
                }
            }
            return r;
        }
    }
}