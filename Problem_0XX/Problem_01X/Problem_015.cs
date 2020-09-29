/*
Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
How many such routes are there through a 20×20 grid?
*/

namespace cs_euler
{
    public class Problem_015 : IProblem
    {
        public long Run()
        {
            long paths = 1;
            for (int i = 1; i <= 20; i++) paths = paths * (41 - i) / i;
            return paths;
        }
    }
}
