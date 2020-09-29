using System.Collections.Generic;

/*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
*/

namespace cs_euler
{
    public class Problem_017 : IProblem
    {
        public long Run()
        {
            List<long> d = new List<long> { 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8, 6, 6, 5, 5, 5, 7, 6, 6, 7 };
            long r = 0;
            for (int n = 0; n < 1000; n++)
            {
                int i = n + 1, h = 0, t = 0;
                if (i == 1000) r += 11;
                else
                {
                    if (i > 99 && i < 1000)
                    {
                        for (; i > 99; i -= 100) h++;
                        r += d[h - 1] + 7;
                        if (i > 0) r += 3;
                    }
                    if (i > 19 && i < 100)
                    {
                        for (; i > 9; i -= 10) t++;
                        r += d[t + 17];
                    }
                    if (i > 0 && i < 20) r += d[i - 1];
                }
            }
            return r;
        }
    }
}