using System.Numerics;

/*
The 5-digit number, 16807=7^5, is also a fifth power. Similarly, the 9-digit number, 134217728=8^9, is a ninth power.
How many n-digit positive integers exist which are also an nth power?
*/

namespace cs_euler
{
    public class Problem_063 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int i = 1; i < 25; i++) for (int j = 1; j <= 9; j++) if (BigInteger.Pow(j, i).ToString().Length == i) r++;
            return r;
        }
    }
}
