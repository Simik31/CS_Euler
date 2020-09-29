using CodeBase;

/*
Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
1634 = 1^4 + 6^4 + 3^4 + 4^4
8208 = 8^4 + 2^4 + 0^4 + 8^4
9474 = 9^4 + 4^4 + 7^4 + 4^4
As 1 = 1^4 is not a sum it is not included.
The sum of these numbers is 1634 + 8208 + 9474 = 19316.
Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
*/

namespace cs_euler
{
    public class Problem_030 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int n = 2; n < 200000; n++)
            {
                string s = n.ToString();
                long t = 0;
                for (int i = 0; i < s.Length; i++) t += Pow.Long(int.Parse(s.Substring(i, 1)), 5);
                if (t == n) r += n;
            }
            return r;
        }
    }
}
