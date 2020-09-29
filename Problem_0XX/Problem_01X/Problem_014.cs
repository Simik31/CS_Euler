using System.Collections.Generic;

/*
The following iterative sequence is defined for the set of positive integers:
n → n/2 (n is even)
n → 3n + 1 (n is odd)
Using the rule above and starting with 13, we generate the following sequence:
13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
Which starting number, under one million, produces the longest chain?
NOTE: Once the chain starts the terms are allowed to go above one million.
*/

namespace cs_euler
{
    public class Problem_014 : IProblem
    {
        public long Run()
        {
            Dictionary<long, long> seen = new Dictionary<long, long>();
            long l, c = -1, r = -1;
            for (long s = 800000; s < 850000; s++)
            {
                l = 0;
                for (long n = s; n != 1; l++)
                {
                    if (seen.ContainsKey(n))
                    {
                        l += seen[n];
                        break;
                    }
                    else if (n % 2 == 0) n /= 2;
                    else n = 3 * n + 1;
                }
                seen.Add(s, l);
                if (l > c)
                {
                    c = l;
                    r = s;
                }
            }
            return r;
        }
    }
}
