using CodeBase;

/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a^2 + b^2 = c^2
For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/

namespace cs_euler
{
    public class Problem_009 : IProblem
    {
        public long Run()
        {
            for (int a = 200; a < 400; a++)
                for (int b = 300; b < 500; b++)
                    for (int c = 400; c < 600; c++)
                        if (a + b + c == 1000 && PythagoreanTheorem.isValid(a, b, c))
                            return a * b * c;
            return -1;
        }
    }
}
