using System;

/*
A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
*/

namespace cs_euler
{
    public class Problem_023 : IProblem
    {
        public long Run()
        {
            int r = 0;
            bool[] a = new bool[28124];
            for (int i = 1; i < 28124; i++)
            {
                int s = 1, e = (int)Math.Sqrt(i);
                for (int j = 2; j <= e; j++) if (i % j == 0) s += j + i / j;
                if (e * e == i) s -= e;
                a[i] = s > i;
                bool b = true;
                for (int j = 0; j <= i; j++)
                {
                    if (a[j] && a[i - j])
                    {
                        b = false;
                        break;
                    }
                }
                if (b) r += i;
            }
            return r;
        }
    }
}
