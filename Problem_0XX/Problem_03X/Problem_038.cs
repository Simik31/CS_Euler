using System;
using System.Collections.Generic;

/*
Take the number 192 and multiply it by each of 1, 2, and 3:
192 × 1 = 192
192 × 2 = 384
192 × 3 = 576
By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and (1,2,3)
The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and (1,2,3,4,5).
What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1?
*/

namespace cs_euler
{
    public class Problem_038 : IProblem
    {
        public long Run()
        {
            long r = 0;
            for (int n = 1; n < 10000; n++)
            {
                string s = "";
                HashSet<char> h = new HashSet<char>();
                for (int i = 1; s.Length < 9; i++)
                {
                    String m = (n * i).ToString();
                    s += m;
                    if (s.Contains("0")) break;
                    foreach (char c in m.ToCharArray()) h.Add(c);
                }
                if (h.Count == 9 && s.Length == 9 && long.Parse(s) > r) r = long.Parse(s);
            }
            return r;
        }
    }
}
