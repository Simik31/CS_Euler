using System;

/*
If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
{20,48,52}, {24,45,51}, {30,40,50}
For which value of p ≤ 1000, is the number of solutions maximised?
*/

namespace cs_euler
{
    public class Problem_039 : IProblem
    {
        public long Run()
        {
            int r = 0, m = 0;
            for (int p = 1; p < 1001; p++)
            {
                int c = 0;
                for (int a = 1; a < 400; a++) for (int b = 1; b < 400; b++) if (a + b + Math.Sqrt(a * a + b * b) == p) c++;
                if (c > m)
                {
                    r = p;
                    m = c;
                }
            }
            return r;
        }
    }
}
