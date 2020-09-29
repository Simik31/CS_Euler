using CodeBase;
using System.Numerics;

/*
Consider quadratic Diophantine equations of the form:
x2 – Dy2 = 1
For example, when D=13, the minimal solution in x is 6492 – 13×1802 = 1.
It can be assumed that there are no solutions in positive integers when D is square.
By finding minimal solutions in x for D = {2, 3, 5, 6, 7}, we obtain the following:
32 – 2×22 = 1
22 – 3×12 = 1
92 – 5×42 = 1
52 – 6×22 = 1
82 – 7×32 = 1
Hence, by considering minimal solutions in x for D ≤ 7, the largest x is obtained when D=5.
Find the value of D ≤ 1000 in minimal solutions of x for which the largest value of x is obtained.
*/

namespace cs_euler
{
    public class Problem_066 : IProblem
    {
        public long Run()
        {
            int r = 0;
            BigInteger p = BigInteger.Zero;
            for (int D = 2; D <= 1000; D++)
            {
                BigInteger l = new BigInteger(SquareNumber.reverse(D));
                if (BigInteger.Multiply(l, l).Equals(new BigInteger(D))) continue;
                BigInteger m = BigInteger.Zero, d = BigInteger.One, a = l, s = BigInteger.One, n = a, u = BigInteger.Zero, o = BigInteger.One;
                while (!BigInteger.Subtract(BigInteger.Multiply(n, n), BigInteger.Multiply(BigInteger.Multiply(o, o), new BigInteger(D))).Equals(BigInteger.One))
                {
                    m = BigInteger.Subtract(BigInteger.Multiply(d, a), m);
                    d = BigInteger.Divide(new BigInteger(D - int.Parse(BigInteger.Multiply(m, m).ToString())), d);
                    a = BigInteger.Divide(BigInteger.Add(l, m), d);
                    BigInteger q = s;
                    s = n;
                    BigInteger t = u;
                    u = o;
                    n = BigInteger.Add(BigInteger.Multiply(a, n), q);
                    o = BigInteger.Add(BigInteger.Multiply(a, u), t);
                }
                if (n.CompareTo(p) > 0)
                {
                    p = n;
                    r = D;
                }
            }
            return r;
        }

    }
}
