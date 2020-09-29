using System.Numerics;

/*
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
What is the sum of the digits of the number 2^1000?
*/

namespace cs_euler
{
    public class Problem_016 : IProblem
    {
        public long Run()
        {
            long s = 0;
            char[] v = BigInteger.Pow(2, 1000).ToString().ToCharArray();
            foreach (char c in v) s += c - '0';
            return s;
        }
    }
}
