using System.Collections.Generic;
using CodeBase;

/*
Euler's Totient function, φ(n) [sometimes called the phi function], is used to determine the number of positive numbers less than or equal to n which are relatively prime to n. For example, as 1, 2, 4, 5, 7, and 8, are all less than nine and relatively prime to nine, φ(9)=6.
The number 1 is considered to be relatively prime to every positive number, so φ(1)=1.
Interestingly, φ(87109)=79180, and it can be seen that 87109 is a permutation of 79180.
Find the value of n, 1 < n < 107, for which φ(n) is a permutation of n and the ratio n/φ(n) produces a minimum.
*/

namespace cs_euler
{
    public class Problem_070 : IProblem
    {
        public long Run()
        {
            long r = 1;
            double b = double.PositiveInfinity;
            List<long> p = Prime.GetInRange(2000, 5000);
            for (int i = 0; i < p.Count; i++)
            {
                for (int j = i + 1; j < p.Count; j++)
                {
                    long n = p[i] * p[j];
                    if (n < 10000001)
                    {
                        long phi = (p[i] - 1) * (p[j] - 1);
                        double ratio = n * 1.0 / phi;
                        if (IsPerm(n, phi) && b > ratio)
                        {
                            r = n;
                            b = ratio;
                        }
                    }
                }
            }
            return r;
        }

        private static bool IsPerm(long m, long n)
        {
            int[] a = new int[10];
            while (n > 0)
            {
                a[(int)(n % 10)]++;
                n /= 10;
            }
            while (m > 0)
            {
                a[(int)(m % 10)]--;
                m /= 10;
            }
            for (int i = 0; i < 10; i++) if (a[i] != 0) return false;
            return true;
        }
    }
}
