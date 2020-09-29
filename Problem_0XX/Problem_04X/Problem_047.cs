using CodeBase;

/*
The first two consecutive numbers to have two distinct prime factors are:
14 = 2 × 7
15 = 3 × 5
The first three consecutive numbers to have three distinct prime factors are:
644 = 2^2 × 7 × 23
645 = 3 × 5 × 43
646 = 2 × 17 × 19.
Find the first four consecutive integers to have four distinct prime factors each. What is the first of these numbers?
*/

namespace cs_euler
{
    public class Problem_047 : IProblem
    {
        public long Run()
        {
            for (int i = 132951; ; i += 3)
                if (Prime.PrimeDivisors(i).Count == 4)
                    if (Prime.PrimeDivisors(i + 1).Count == 4)
                        if (Prime.PrimeDivisors(i + 2).Count == 4)
                            if (Prime.PrimeDivisors(i + 3).Count == 4) return i;
        }
    }
}
