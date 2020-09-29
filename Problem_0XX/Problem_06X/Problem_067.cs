using System;
using System.Collections.Generic;

/*
DATA: https://projecteuler.net/project/resources/p067_triangle.txt
By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

   3        3         3         3        23
  7 4      7 #       7 #      20 #
 2 4 6    # 4 #    13 # #
8 5 9 3  # # 9 #

That is, 3 + 7 + 4 + 9 = 23.
Find the maximum total from top to bottom in triangle.txt (right click and 'Save Link/Target As...'), a 15K text file containing a triangle with one-hundred rows.
NOTE: This is a much more difficult version of Problem 18. It is not possible to try every route to solve this problem, as there are 299 altogether! If you could check one trillion (10^12) routes every second it would take over twenty billion years to check them all. There is an efficient algorithm to solve it. ;o)
*/

namespace cs_euler
{
    public class Problem_067 : IProblem
    {
        public long Run()
        {
            List<List<int>> t = new List<List<int>>();
            string[] r = Reader.File(67);
            foreach (string l in r)
            {
                List<int> m = new List<int>();
                foreach (string n in l.Split(" ")) m.Add(int.Parse(n));
                t.Add(m);
            }
            for (int a = t.Count - 2; a >= 0; a--) for (int b = 0; b <= a; b++) t[a][b] += Math.Max(t[a + 1][b], t[a + 1][b + 1]);
            return t[0][0];
        }
    }
}