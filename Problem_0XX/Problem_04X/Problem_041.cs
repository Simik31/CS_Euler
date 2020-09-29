using System.Collections.Generic;
using CodeBase;

/*
We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.
What is the largest n-digit pandigital prime that exists?
*/

namespace cs_euler
{
    public class Problem_041 : IProblem
    {
        public long Run()
        {
            for (long n = 7654321; ; n--)
            {
                string s = n.ToString();
                if (!s.Contains("0") && Prime.Check(s))
                {
                    HashSet<int> h = new HashSet<int>();
                    for (int i = 0; i < s.Length; i++)
                    {
                        int m = int.Parse(s.Substring(i, 1));
                        if (!(m > 0 && m <= s.Length)) break;
                        h.Add(m);
                    }
                    if (h.Count == s.Length) return n;
                }
            }
        }
    }
}
