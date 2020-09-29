using CodeBase;

/*
The sum of the squares of the first ten natural numbers is,
1^2+2^2+...+10^2=385
The square of the sum of the first ten natural numbers is,
(1+2+...+10)^2=55^2=3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025−385=2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

namespace cs_euler
{
    public class Problem_006 : IProblem
    {
        public long Run()
        {
            long a = 0, b = 0;
            for (int n = 1; n <= 100; n++)
            {
                a += Pow.Long(n, 2);
                b += n;
            }
            return Pow.Long(b, 2) - a;
        }
    }
}
