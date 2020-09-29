using System;
using System.Collections.Generic;
using System.Text;

/*
Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

21 22 23 24 25
20  7  8  9 10
19  6  1  2 11
18  5  4  3 12
17 16 15 14 13

It can be verified that the sum of the numbers on the diagonals is 101.
What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
*/

namespace cs_euler
{
    public class Problem_028 : IProblem
    {
        public long Run()
        {
            int r = 0, l = 0, c = 3;
            for (int n = 1; n <= 1002001; n += 2 * l)
            {
                r += n;
                if (++c == 4)
                {
                    c = 0;
                    l++;
                }
            }
            return r;
        }
    }
}
