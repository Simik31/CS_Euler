using System;
using CodeBase;

/*
All square roots are periodic when written as continued fractions and can be written in the form:
If we continue we would get the following expansion:
The process can be summarised as follows:
It can be seen that the sequence is repeating. For conciseness, we use the notation 23−−√=[4;(1,3,1,8)], to indicate that the block (1,3,1,8) repeats indefinitely.
The first ten continued fraction representations of (irrational) square roots are:
√2=[1;(2)], period=1
√3=[1;(1,2)], period=2
√5=[2;(4)], period=1
√6=[2;(2,4)], period=2
√7=[2;(1,1,1,4)], period=4
√8=[2;(1,4)], period=2
√10=[3;(6)], period=1
√11=[3;(3,6)], period=2
√12=[3;(2,6)], period=2
√13=[3;(1,1,1,1,6)], period=5
Exactly four continued fractions, for N≤13, have an odd period.
How many continued fractions for N≤10000 have an odd period?
*/

namespace cs_euler
{
    public class Problem_064 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int i = 2; i <= 10000; i++)
            {
                int l = (int)Math.Sqrt(i);
                if (SquareNumber.get(l) != i)
                {
                    int a = l, d = 1, m = 0, p = 0;
                    do
                    {
                        m = d * a - m;
                        d = (i - m * m) / d;
                        a = (l + m) / d;
                        p++;
                    } while (a != 2 * l);
                    if (p % 2 == 1) r++;
                }
            }
            return r;
        }
    }
}
