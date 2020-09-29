using System.Collections.Generic;
using CodeBase;

/*
The prime 41, can be written as the sum of six consecutive primes:
41 = 2 + 3 + 5 + 7 + 11 + 13
This is the longest sum of consecutive primes that adds to a prime below one-hundred.
The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
Which prime, below one-million, can be written as the sum of the most consecutive primes?
*/

namespace cs_euler
{
   public class Problem_050 : IProblem
    {
        public long Run()
        {
            List<long> p = Prime.GetBellow(1000000);
            for (int i = 3; ; i++)
            {
                for (int l = 540; l < p.Count - i; l++)
                {
                    long s = 0;
                    for (int a = 0; a < l; a++) s += p[i + a];
                    if (s < 1000000 && Prime.Check(s)) return s;
                }
            }
        }
    }
}
