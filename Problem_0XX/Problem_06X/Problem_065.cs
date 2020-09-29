using System.Numerics;

namespace cs_euler
{
    public class Problem_065 : IProblem
    {
        public long Run()
        {
            int r = 0;
            BigInteger d = new BigInteger(1);
            BigInteger n = new BigInteger(2);
            for (int i = 2; i <= 100; i++)
            {
                BigInteger t = d;
                d = n;
                if (i % 3 == 0) n = BigInteger.Add(BigInteger.Multiply(d, new BigInteger(2 * (i / 3))), t);
                else n = BigInteger.Add(d, t);
            }
            foreach (char c in n.ToString().ToCharArray()) r += c - '0';
            return r;
        }
    }
}
