using System.Collections.Generic;
using System.Numerics;

/*
It is possible to show that the square root of two can be expressed as an infinite continued fraction.
2–√=1+12+12+12+…
By expanding this for the first four iterations, we get:
1+1/2 = 3/2 = 1.5
1+1/(2+1/2) = 7/5 = 1.4
1+1/(2+1/(2+1/2)) = 17/12 = 1.41666…
1+1/(2+1/(2+1/(2+1/2))) = 41/29 = 1.41379…
The next three expansions are 99/70, 239/169, and 577/408, but the eighth expansion, 1393/985, is the first example where the number of digits in the numerator exceeds the number of digits in the denominator.
In the first one-thousand expansions, how many fractions contain a numerator with more digits than the denominator?
*/

namespace cs_euler
{
    public class Problem_057 : IProblem
    {
        static readonly Dictionary<int, string> s = new Dictionary<int, string>();

        public long Run()
        {
            int r = 0;
            for (int i = 0; i < 1000; i++)
            {
                string f = Fraction(i), n = f.Split("/")[0], d = f.Split("/")[1];
                if (BigInteger.Add(BigInteger.Parse(d), BigInteger.Parse(n)).ToString().Length > d.Length) r++;
            }
            return r;
        }

        static string Fraction(int iter)
        {
            if (iter == 0) return "1/2";
            else if (s.ContainsKey(iter)) return s[iter];
            else
            {
                string f = Fraction(iter - 1), n = f.Split("/")[0], d = f.Split("/")[1];
                string r = string.Format("{0}/{1}", d, BigInteger.Add(BigInteger.Multiply(BigInteger.Parse(d), 2), BigInteger.Parse(n)));
                s.Add(iter, r);
                return r;
            }
        }
    }
}
