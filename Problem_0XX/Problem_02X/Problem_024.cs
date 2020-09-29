using System;
using System.Collections.Generic;

/*
A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
012   021   102   120   201   210
What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
*/

namespace cs_euler
{
    public class Problem_024 : IProblem
    {
        public long Run()
        {
            List<int> a = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int counter = 0;
            foreach (int j in a)
            {
                List<int> b = new List<int>(a);
                b.Remove(j);
                foreach (int k in b)
                {
                    List<int> c = new List<int>(b);
                    c.Remove(k);
                    foreach (int l in c)
                    {
                        List<int> d = new List<int>(c);
                        d.Remove(l);
                        foreach (int m in d)
                        {
                            List<int> e = new List<int>(d);
                            e.Remove(m);
                            foreach (int n in e)
                            {
                                List<int> f = new List<int>(e);
                                f.Remove(n);
                                foreach (int o in f)
                                {
                                    List<int> g = new List<int>(f);
                                    g.Remove(o);
                                    foreach (int p in g)
                                    {
                                        List<int> h = new List<int>(g);
                                        h.Remove(p);
                                        foreach (int q in h)
                                        {
                                            List<int> i = new List<int>(h);
                                            i.Remove(q);
                                            if (++counter == 1000000) return long.Parse(String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", j, k, l, m, n, o, p, q, i[0], i[1]));
                                            if (++counter == 1000000) return long.Parse(String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", j, k, l, m, n, o, p, q, i[1], i[0]));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
