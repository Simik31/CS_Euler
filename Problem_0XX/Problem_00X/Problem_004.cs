using CodeBase;

/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*/

namespace cs_euler
{
    public class Problem_004 : IProblem
    {
        public long Run()
        {
            int multiple, highest_palindrome = 0;
            for (int a = 900; a < 1000; a++)
            {
                for (int b = 900; b < 1000; b++)
                {
                    multiple = a * b;
                    if (multiple > highest_palindrome && Palindromic.check(multiple)) highest_palindrome = multiple;
                }
            }
            return highest_palindrome;
        }
    }
}
