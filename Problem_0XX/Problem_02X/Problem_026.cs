/*
A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
1/2	= 	0.5
1/3	= 	0.(3)
1/4	= 	0.25
1/5	= 	0.2
1/6	= 	0.1(6)
1/7	= 	0.(142857)
1/8	= 	0.125
1/9	= 	0.(1)
1/10	= 	0.1
Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
 */

namespace cs_euler
{
    public class Problem_026 : IProblem
    {
        public long Run()
        {
            int r = 0, l = 0;
            for (int i = 2; i < 1000; i++)
            {
                int[] a = new int[i + 1];
                int j = 1, m = 1;
                while (m != 0 && a[m] == 0)
                {
                    a[m] = j++;
                    m = m * 10 % i;
                }
                if (j - a[m] > l)
                {
                    l = j - a[m];
                    r = i;
                }
            }
            return r;
        }
    }
}
