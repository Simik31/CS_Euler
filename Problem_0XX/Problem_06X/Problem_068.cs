namespace cs_euler
{
    public class Problem_068 : IProblem
    {
        public long Run()
        {
            string r = "";
            int[] p = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            while (GetNextPerm(p))
            {
                if (p[1] != 10 && p[2] != 10 && p[4] != 10 && p[6] != 10 && p[8] != 10 && p[0] <= p[3] && p[0] <= p[5] && p[0] <= p[7] && p[0] <= p[9] && p[0] + p[1] + p[2] == p[3] + p[2] + p[4] && p[0] + p[1] + p[2] == p[5] + p[4] + p[6] && p[0] + p[1] + p[2] == p[7] + p[6] + p[8] && p[0] + p[1] + p[2] == p[9] + p[8] + p[1])
                {
                    string c = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}", p[0], p[1], p[2], p[3], p[2], p[4], p[5], p[4], p[6], p[7], p[6], p[8], p[9], p[8], p[1]);
                    if (c.CompareTo(r) > 0) r = c;
                }
            }
            return long.Parse(r);
        }

        private static bool GetNextPerm(int[] p)
        {
            int N = p.Length;
            int i = N - 1, j = N;
            while (p[i - 1] >= p[i]) if (--i < 1) return false;
            while (p[j - 1] <= p[i - 1]) j--;
            int k = p[i - 1];
            p[i - 1] = p[j - 1];
            p[j - 1] = k;
            i++;
            j = N;
            while (i < j)
            {
                k = p[i - 1];
                p[i - 1] = p[j - 1];
                p[j - 1] = k;
                i++;
                j--;
            }
            return true;
        }
    }
}
