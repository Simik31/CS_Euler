using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace cs_euler
{
    public class Solve
    {
        private readonly List<IProblem> problems;
        private readonly int barRes = 3;
        private int coded = Euler.problems_coded;
        private string bar = "";

        public Solve()
        {
            problems = new List<IProblem>
            {
                new Problem_001(),
                new Problem_002(),
                new Problem_003(),
                new Problem_004(),
                new Problem_005(),
                new Problem_006(),
                new Problem_007(),
                new Problem_008(),
                new Problem_009(),
                new Problem_010(),
                new Problem_011(),
                new Problem_012(),
                new Problem_013(),
                new Problem_014(),
                new Problem_015(),
                new Problem_016(),
                new Problem_017(),
                new Problem_018(),
                new Problem_019(),
                new Problem_020(),
                new Problem_021(),
                new Problem_022(),
                new Problem_023(),
                new Problem_024(),
                new Problem_025(),
                new Problem_026(),
                new Problem_027(),
                new Problem_028(),
                new Problem_029(),
                new Problem_030(),
                new Problem_031(),
                new Problem_032(),
                new Problem_033(),
                new Problem_034(),
                new Problem_035(),
                new Problem_036(),
                new Problem_037(),
                new Problem_038(),
                new Problem_039(),
                new Problem_040(),
                new Problem_041(),
                new Problem_042(),
                new Problem_043(),
                new Problem_044(),
                new Problem_045(),
                new Problem_046(),
                new Problem_047(),
                new Problem_048(),
                new Problem_049(),
                new Problem_050(),
                new Problem_051(),
                new Problem_052(),
                new Problem_053(),
                new Problem_054(),
                new Problem_055(),
                new Problem_056(),
                new Problem_057(),
                new Problem_058(),
                new Problem_059(),
                new Problem_060(),
                new Problem_061(),
                new Problem_062(),
                new Problem_063(),
                new Problem_064(),
                new Problem_065(),
                new Problem_066(),
                new Problem_067(),
                new Problem_068(),
                new Problem_069(),
                new Problem_070(),
                new Problem_071(),
                new Problem_072(),
                new Problem_073(),
                new Problem_074(),
                new Problem_075()
            };

            if (problems.Count < Euler.problems_coded) throw new Exception("Problem missing from list");
        }

        public void All()
        {
            string all;
            if (Euler.debug)
            {
                Console.CursorVisible = true;
                do
                {
                    Console.Write("[*] Is last problem done? y/n: ");
                    all = Console.ReadLine();
                    Console.Clear();
                } while (all != "y" && all != "Y" && all != "n" && all != "N");
                Console.CursorVisible = false;
                if (all == "n" || all == "N") coded--;
            }
            for (int i = 1; i <= coded; i++)
            {
                bar = " █";
                for (int j = barRes - 1; j < 100; j += barRes) bar = String.Format("{0}{1}", bar, (i * 100 / coded > j) ? "█" : "░");
                bar = string.Format("{0}█ {1, 7:#.000}%", bar, Math.Round(i * 100.0 / coded, 3));
                Problem(i);
            }
        }

        public void Problem(int id)
        {
            Console.Title = String.Format("{0} - Solving problem {1} {2}", Euler.title, id, (bar.Length > 0) ? String.Format(" / {0} {1}", coded, bar) : "");
            Console.Write("[*]{0} Problem {1, 3}: ", bar, id);
            
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long answer = problems[id - 1].Run();
            sw.Stop();

            long ms = sw.ElapsedMilliseconds;
            Euler.times.Add(ms);
            
            Console.Write("{0, 25:#,##0} [Time {1}: ", answer, (ms > 1000 ? ">>" : "OK"));
            Console.ForegroundColor = (ms > 499) ? ((ms > 999) ? ConsoleColor.Red : ConsoleColor.Yellow) : ConsoleColor.Green;
            Console.Write("{0, 7:#,##0}ms", ms);
            Console.ResetColor();
            Console.WriteLine("]");
            Console.Title = Euler.title;
        }
    }
}
