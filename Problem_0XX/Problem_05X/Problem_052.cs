using System.Collections.Generic;

/*
It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.
*/

namespace cs_euler
{
    public class Problem_052 : IProblem
    {
        public long Run()
        {
            for (int x = 1; ; x++)
            {
                HashSet<string>[] h = new HashSet<string>[5];
                for (int n = 2; n <= 6; n++)
                {
                    string s = (n * x).ToString();
                    h[n - 2] = new HashSet<string>();
                    for (int i = 0; i < s.Length; i++) h[n - 2].Add(s.Substring(i, 1));
                }
                if (h[0].SetEquals(h[1]) && h[0].SetEquals(h[2]) && h[0].SetEquals(h[3]) && h[0].SetEquals(h[4])) return x;
            }
        }
    }
}
