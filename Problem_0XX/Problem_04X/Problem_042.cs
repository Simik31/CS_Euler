using System;
using System.Collections.Generic;
using CodeBase;

/*
DATA: https://projecteuler.net/project/resources/p042_words.txt
The nth term of the sequence of triangle numbers is given by, tn = 1/2n(n+1); so the first ten triangle numbers are:
1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. If the word value is a triangle number then we shall call the word a triangle word.
Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?
*/

namespace cs_euler
{
    public class Problem_042 : IProblem
    {
        public long Run()
        {
            List<long> t = new List<long>();
            for (int n = 1; n <= 26; n++) t.Add(TriangleNumber.get(n));
            int r = 0;
            String[] f = Reader.File(42);
            foreach (String l in f)
            {
                foreach (String w in l.Split(","))
                {
                    char[] s = w.Replace("\"", "").ToCharArray();
                    long n = 0;
                    foreach (char c in s) n += c - '@';
                    if (t.Contains(n)) r++;
                }
            }
            return r;
        }
    }
}
