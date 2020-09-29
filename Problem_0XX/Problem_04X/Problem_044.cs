﻿using System;
using System.Collections.Generic;
using CodeBase;

/*
Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2. The first ten pentagonal numbers are:
1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ...
It can be seen that P4 + P7 = 22 + 70 = 92 = P8. However, their difference, 70 − 22 = 48, is not pentagonal.
Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = |Pk − Pj| is minimised; what is the value of D?
*/

namespace cs_euler
{
    public class Problem_044 : IProblem
    {
        public long Run()
        {
            List<long> p = new List<long>();
            for (int n = 1000; n <= 3250; n++) p.Add(PentagonalNumber.get(n));
            for (int j = 0; j < p.Count - 1; j++)
                for (int k = j; k < p.Count; k++)
                    if (p.Contains(p[j] + p[k]) && p.Contains(p[k] - p[j])) return Math.Abs(p[k] - p[j]);
            return -1;
        }
    }
}
