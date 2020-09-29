using CodeBase;

/*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10001st prime number?
 */

namespace cs_euler
{
    public class Problem_007 : IProblem
    {
        public long Run()
        {
            return Prime.GetNth(10001);
        }
    }
}
