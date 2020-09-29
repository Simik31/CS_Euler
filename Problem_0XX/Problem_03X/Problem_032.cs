using System.Collections.Generic;

/*
We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
*/

namespace cs_euler
{
    public class Problem_032 : IProblem
    {
        public long Run()
        {
            HashSet<int> a = new HashSet<int>();
            int r = 0;
            for (int i = 1; i < 10000 + 1; i++)
            {
                for (int j = 1; j < (10000 / i) + 1; j++)
                {
                    int m = i * j;
                    if (a.Contains(m)) continue;
                    string w = string.Format("{0}{1}{2}", i, j, m);
                    if (w.Length != 9 || w.Contains("0")) continue;
                    HashSet<char> s = new HashSet<char>();
                    foreach (char c in w.ToCharArray()) s.Add(c);
                    if (s.Count == 9)
                    {
                        a.Add(m);
                        r += m;
                    }
                }
            }
            return r;
        }
    }
}
