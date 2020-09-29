using System.Collections.Generic;

/*
DATA: https://projecteuler.net/project/resources/p022_names.txt
Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
What is the total of all the name scores in the file?
*/

namespace cs_euler
{
    public class Problem_022 : IProblem
    {
        public long Run()
        {
            List<string> n = new List<string>();
            string[] f = Reader.File(22);
            foreach (string l in f) foreach(string m in l.Split(",")) n.Add(m.Replace("\"", ""));
            n.Sort();
            long r = 0;
            for (int i = 1; i <= n.Count; i++) foreach (char c in n[i - 1].ToCharArray()) r += (c - '@') * i;
            return r;
        }
    }
}
