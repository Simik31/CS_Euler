using CodeBase;

/*
145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
Find the sum of all numbers which are equal to the sum of the factorial of their digits.
Note: as 1! = 1 and 2! = 2 are not sums they are not included.
*/

namespace cs_euler
{
    public class Problem_034 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int n = 3; n < 41000; n++)
            {
                string s = n.ToString();
                int f = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    f += Factorial.Integer(int.Parse(s.Substring(i, 1)));
                    if (f > n) break;
                }
                if (n == f) r += n;
            }
            return r;
        }
    }
}
