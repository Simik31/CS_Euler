using CodeBase;
using System;

/*
The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
(Please note that the palindromic number, in either base, may not include leading zeros.)
*/

namespace cs_euler
{
    public class Problem_036 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int n = 1; n < 1000001; n++) if (Palindromic.check(n) && Palindromic.check(Convert.ToString(n, 2))) r += n;
            return r;
        }
    }
}
