using System.Text;

/*
An irrational decimal fraction is created by concatenating the positive integers:
0.123456789101112131415161718192021...
It can be seen that the 12th digit of the fractional part is 1.
If dn represents the n-th digit of the fractional part, find the value of the following expression.
d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
*/

namespace cs_euler
{
    public class Problem_040 : IProblem
    {
        public long Run()
        {
            StringBuilder b = new StringBuilder();
            for (long i = 1; b.Length < 1000000; i++) b.Append(i);
            char[] n = b.ToString().ToCharArray();
            return (n[0] - '0') * (n[9] - '0') * (n[99] - '0') * (n[999] - '0') * (n[9999] - '0') * (n[99999] - '0') * (n[999999] - '0');
        }
    }
}
