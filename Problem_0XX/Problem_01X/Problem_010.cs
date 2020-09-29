using System;

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
*/

namespace cs_euler
{
    public class Problem_010 : IProblem
    {
        public long Run()
        {
            long sum = 2;
            for (long i = 3; i < 1999994; i += 2)
            {
                bool p = true;
                for (int j = 2; j < Math.Sqrt(i) + 1; j++)
                {
                    if (i % j == 0)
                    {
                        p = false;
                        break;
                    }
                }
                if (p) sum += i;
            }
            return sum;
        }
    }
}
