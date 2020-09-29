/*
The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
*/

namespace cs_euler
{
    public class Problem_033 : IProblem
    {
        public long Run()
        {
            int dp = 1, np = 1, gcd = 1;
            for (int c = 1; c <= 9; c++)
            {
                for (int d = 1; d < c; d++)
                {
                    for (int n = 1; n < d; n++)
                    {
                        if ((n * 10 + c) * d == (c * 10 + d) * n)
                        {
                            np *= n;
                            dp *= d;
                        }
                    }
                }
            }
            for (int i = 1; i <= np; i++) if (np % i == 0 && dp % i == 0) gcd = i;
            return dp / gcd;
        }
    }
}
