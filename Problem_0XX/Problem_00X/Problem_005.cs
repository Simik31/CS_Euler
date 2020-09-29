/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

namespace cs_euler
{
    public class Problem_005 : IProblem
    {
        public long Run()
        {
            for (long number = 20; ; number += 20)
            {
                if (number %  7 == 0 && number % 11 == 0 && number % 13 == 0 && 
                    number % 15 == 0 && number % 16 == 0 && number % 17 == 0 && 
                    number % 18 == 0 && number % 19 == 0 && number % 20 == 0) return number;
            }
        }
    }
}
