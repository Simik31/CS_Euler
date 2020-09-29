using System;
using CodeBase;

/*
The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
*/

namespace cs_euler
{
    public class Problem_037 : IProblem
    {
        public long Run()
        {
            int r = 0, c = 0;
            for (int n = 10; c < 11; n++)
            {
                String s = n.ToString();
                bool p = true;
                for (int i = 0; i < s.Length; i++)
                {
                    String a = s.Substring(i), b = s.Substring(0, s.Length - i);
                    if (a.Equals("1") || b.Equals("1") || !(Prime.Check(a) && Prime.Check(b)))
                    {
                        p = false;
                        break;
                    }
                }
                if (p)
                {
                    r += n;
                    c++;
                }
            }
            return r;
        }
    }
}
