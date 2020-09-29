/*
Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
Evaluate the sum of all the amicable numbers under 10000.
*/

namespace cs_euler
{
    public class Problem_021 : IProblem
    {
        public long Run()
        {
            int s = 0;
            for (int i = 1; i <= 10000; i++)
            {
                int a = 0, b = 0;
                for (int j = 1; j < i; j++) if (i % j == 0) a += j;
                for (int k = 1; k < a; k++) if (a % k == 0) b += k;
                if (a == b || i != b) continue;
                s += a + b;
            }
            return s;
        }
    }
}
