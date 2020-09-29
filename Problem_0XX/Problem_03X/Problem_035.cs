using System;
using CodeBase;

/*
The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
How many circular primes are there below one million?
*/

namespace cs_euler
{
    public class Problem_035 : IProblem
    {
        public long Run()
        {
            int r = 0;
            for (int n = 2; n < 1000001; n++)
            {
                String s = n.ToString();
                bool p = true;
                for (int i = 0; i < s.Length; i++)
                {
                    if (!Prime.Check(int.Parse(s.Substring(i) + s.Substring(0, i))))
                    {
                        p = false;
                        break;
                    }
                }
                if (p) r++;
            }
            return r;
        }
    }
}
