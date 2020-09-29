using CodeBase;

/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/

namespace cs_euler
{
    public class Problem_003 : IProblem
    {
        public long Run()
        {
            return Prime.BiggestPrimeDivisor(600851475143);
        }
    }
}
