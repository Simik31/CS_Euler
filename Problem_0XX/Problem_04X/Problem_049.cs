using System.Collections.Generic;
using CodeBase;

/*
The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.
There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.
What 12-digit number do you form by concatenating the three terms in this sequence?
*/

namespace cs_euler
{
    public class Problem_049 : IProblem
    {
        public long Run()
        {
            for (int m = 1488; ; m++)
            {
                HashSet<string> h = new HashSet<string>();
                string s = m.ToString();
                for (int i = 0; i < s.Length; i++) h.Add(s.Substring(i, 1));
                if (Prime.Check(m))
                {
                    int n = m + 3330;
                    if (Prime.Check(n))
                    {
                        bool a = true;
                        string t = n.ToString();
                        for (int i = 0; i < t.Length; i++) if (!h.Contains(t.Substring(i, 1))) a = false;
                        if (a)
                        {
                            int o = n + 3330;
                            if (Prime.Check(o))
                            {
                                bool b = true;
                                string u = o.ToString();
                                for (int i = 0; i < u.Length; i++) if (!h.Contains(t.Substring(i, 1))) b = false;
                                if (b) return long.Parse(string.Format("{0}{1}{2}", m, n, o));
                            }
                        }
                    }
                }
            }
        }
    }
}
