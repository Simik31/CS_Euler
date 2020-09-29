using System;
using System.Collections.Generic;
using System.Text;

namespace cs_euler
{
    class Reader
    {
        public static String[] File(int problem_id)
        {
            return System.IO.File.ReadAllLines(string.Format(@"../../../data/{0:000}.txt", problem_id));
        }
    }
}
