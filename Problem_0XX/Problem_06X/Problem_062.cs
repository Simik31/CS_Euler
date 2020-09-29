using System.Collections.Generic;
using CodeBase;

/*
The cube, 41063625 (3453), can be permuted to produce two other cubes: 56623104 (3843) and 66430125 (4053). In fact, 41063625 is the smallest cube which has exactly three permutations of its digits which are also cube.
Find the smallest cube for which exactly five permutations of its digits are cube.
*/

namespace cs_euler
{
    public class Problem_062 : IProblem
    {
        public long Run()
        {
            Dictionary<long, long[]> c = new Dictionary<long, long[]>();
            for (long n = 0; ; n++)
            {
                long k = CubeNumber.get(n), s = 0;
                int[] d = new int[10];
                while (k > 0)
                {
                    d[(int)(k % 10)]++;
                    k /= 10;
                }
                for (int i = 9; i >= 0; i--) for (int j = 0; j < d[i]; j++) s = s * 10 + i;
                if (!c.ContainsKey(s)) c.Add(s, new long[] { n, 0L });
                if (++c[s][1] == 5) return CubeNumber.get(c[s][0]);
            }
        }
    }
}
