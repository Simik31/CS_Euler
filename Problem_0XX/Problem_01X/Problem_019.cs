using System;

/*
You are given the following information, but you may prefer to do some research for yourself.
1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
*/

namespace cs_euler
{
    public class Problem_019 : IProblem
    {
        public long Run()
        {
            int s = 0;
            for (DateTime dt = new DateTime(1901, 1, 6); dt.Year < 2001; dt = dt.AddDays(7)) if (dt.Day == 1 && dt.DayOfWeek.Equals(DayOfWeek.Sunday)) s++;
            return s;
        }
    }
}
