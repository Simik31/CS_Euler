using System.Numerics;

/*
The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
*/

namespace cs_euler
{
    public class Problem_048 : IProblem
    {
        public long Run()
        {
            BigInteger n = BigInteger.Zero;
            for (int i = 1; i <= 1000; i++) n = BigInteger.Add(n, BigInteger.Pow(i, i));
            return long.Parse(n.ToString().Substring(n.ToString().Length - 10));
        }
    }
}
