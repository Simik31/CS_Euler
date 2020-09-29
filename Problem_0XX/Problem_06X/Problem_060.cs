using System.Collections.Generic;
using CodeBase;

/*
The primes 3, 7, 109, and 673, are quite remarkable. By taking any two primes and concatenating them in any order the result will always be prime. For example, taking 7 and 109, both 7109 and 1097 are prime. The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.
Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.
*/

namespace cs_euler
{
    public class Problem_060 : IProblem
    {
        public long Run()
        {
            List<long> p = Prime.GetInRange(13, 8500);
            for (int i = 0; i < p.Count - 4; i++)
            {
                string a = p[i].ToString();
                for (int j = i + 1; j < p.Count - 3; j++)
                {
                    string b = p[j].ToString();
                    if (Prime.CheckSet(new string[] { a + b, b + a }))
                    {
                        for (int k = j + 1; k < p.Count - 2; k++)
                        {
                            string c = p[k].ToString();
                            if (Prime.CheckSet(new string[] { a + c, b + c, c + a, c + b }))
                            {
                                for (int l = k + 1; l < p.Count - 1; l++)
                                {
                                    string d = p[l].ToString();
                                    if (Prime.CheckSet(new string[] { a + d, b + d, c + d, d + a, d + b, d + c }))
                                    {
                                        for (int m = l + 1; m < p.Count; m++)
                                        {
                                            string e = p[m].ToString();
                                            if (Prime.CheckSet(new string[] { a + e, b + e, c + e, d + e, e + a, e + b, e + c, e + d }))
                                            {
                                                return p[i] + p[j] + p[k] + p[l] + p[m];
                                            }
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
