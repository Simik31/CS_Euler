using CodeBase;

/*
By replacing the 1st digit of the 2-digit number *3, it turns out that six of the nine possible values: 13, 23, 43, 53, 73, and 83, are all prime.
By replacing the 3rd and 4th digits of 56**3 with the same digit, this 5-digit number is the first example having seven primes among the ten generated numbers, yielding the family: 56003, 56113, 56333, 56443, 56663, 56773, and 56993. Consequently 56003, being the first member of this family, is the smallest prime with this property.
Find the smallest prime which, by replacing part of the number (not necessarily adjacent digits) with the same digit, is part of an eight prime value family.
*/

namespace cs_euler
{
    public class Problem_051 : IProblem
    {
        public long Run()
        {

            int[][][] p = new int[2][][];
            p[0] = new int[4][];
            p[0][0] = new int[] { 1, 0, 0, 0, 1 };
            p[0][1] = new int[] { 0, 1, 0, 0, 1 };
            p[0][2] = new int[] { 0, 0, 1, 0, 1 };
            p[0][3] = new int[] { 0, 0, 0, 1, 1 };
            p[1] = new int[10][];
            p[1][0] = new int[] { 1, 1, 0, 0, 0, 1 };
            p[1][1] = new int[] { 1, 0, 1, 0, 0, 1 };
            p[1][2] = new int[] { 1, 0, 0, 1, 0, 1 };
            p[1][3] = new int[] { 1, 0, 0, 0, 1, 1 };
            p[1][4] = new int[] { 0, 1, 1, 0, 0, 1 };
            p[1][5] = new int[] { 0, 1, 0, 1, 0, 1 };
            p[1][6] = new int[] { 0, 1, 0, 0, 1, 1 };
            p[1][7] = new int[] { 0, 0, 1, 1, 0, 1 };
            p[1][8] = new int[] { 0, 0, 1, 0, 1, 1 };
            p[1][9] = new int[] { 0, 0, 0, 1, 1, 1 };
            int r = int.MaxValue;
            for (int i = 11; i < 1000; i += 2)
            {
                if (i % 5 == 0) continue;
                int[][] q = p[i < 100 ? 0 : 1];
                foreach (int[] j in q)
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        if (j[0] == 0 && k == 0) continue;
                        int[] s = new int[j.Length];
                        int t = i;
                        for (int l = s.Length - 1; l >= 0; l--)
                        {
                            if (j[l] == 1)
                            {
                                s[l] = t % 10;
                                t /= 10;
                            }
                            else s[l] = -1;
                        }
                        int c = 0;
                        foreach (int v in s)
                        {
                            if (v == -1) c = c * 10 + k;
                            else c = c * 10 + v;
                        }
                        if (c < r && Prime.Check(c))
                        {
                            int f = 1;
                            for (int l = k + 1; l < 10; l++)
                            {
                                t = 0;
                                foreach (int v in s)
                                {
                                    if (v == -1) t = t * 10 + l;
                                    else t = t * 10 + v;
                                }
                                if (Prime.Check(t)) f++;
                            }
                            if (f == 8) r = c;
                            break;
                        }
                    }
                }
            }
            return r;
        }
    }
}
