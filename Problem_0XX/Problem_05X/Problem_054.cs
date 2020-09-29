using System;
using System.Collections.Generic;

/*
DATA: https://projecteuler.net/project/resources/p054_poker.txt
In the card game poker, a hand consists of five cards and are ranked, from lowest to highest, in the following way:

High Card: Highest value card.
One Pair: Two cards of the same value.
Two Pairs: Two different pairs.
Three of a Kind: Three cards of the same value.
Straight: All cards are consecutive values.
Flush: All cards of the same suit.
Full House: Three of a kind and a pair.
Four of a Kind: Four cards of the same value.
Straight Flush: All cards are consecutive values of same suit.
Royal Flush: Ten, Jack, Queen, King, Ace, in same suit.

The cards are valued in the order:
2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King, Ace.
If two players have the same ranked hands then the rank made up of the highest value wins; for example, a pair of eights beats a pair of fives (see example 1 below). But if two ranks tie, for example, both players have a pair of queens, then highest cards in each hand are compared (see example 4 below); if the highest cards tie then the next highest cards are compared, and so on.
Consider the following five hands dealt to two players:

Hand	Player 1	 	   Player 2	 	       Winner
1	 	5H 5C 6S 7S KD    2C 3S 8S 8D TD       Player 2
        Pair of Fives     Pair of Eights

2	 	5D 8C 9S JS AC    2C 5C 7D 8S QH       Player 1
        Highest card Ace  Highest card Queen

3	 	2D 9C AS AH AC    3D 6D 7D TD QD       Player 2
        Three Aces        Flush with Diamonds

4	 	4D 6S 9H QH QC    3D 6D 7H QD QS       Player 1
        Pair of Queens    Pair of Queens
        Highest card Nine  Highest card Seven

5	 	2H 2D 4C 4D 4S     3C 3D 3S 9S 9D      Player 1
        Full House         Full House
        With Three Fours   with Three Threes

The file, poker.txt, contains one-thousand random hands dealt to two players. Each line of the file contains ten cards (separated by a single space): the first five are Player 1's cards and the last five are Player 2's cards. You can assume that all hands are valid (no invalid characters or repeated cards), each player's hand is in no specific order, and in each hand there is a clear winner.
How many hands does Player 1 win?
*/

namespace cs_euler
{
    public class Problem_054 : IProblem
    {
        public long Run()
        {
            Dictionary<char, int> v = new Dictionary<char, int> { { '2', 2 }, { '3', 3 }, { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 }, { '8', 8 }, { '9', 9 },  { 'T', 10 }, { 'J', 11 }, { 'Q', 12 }, { 'K', 13 }, { 'A', 14 } };
            Dictionary<char, int> s = new Dictionary<char, int> { { 'C', 1 }, { 'D', 2 }, { 'H', 3 }, { 'S', 4 } };
            int ret = 0, p1Id, p2Id, max = 14;
            String[] reader = Reader.File(054);
            foreach (String line in reader)
            {
                char[] c = line.ToCharArray();
                List<int> p1v = new List<int>(), p2v = new List<int>(), p1s = new List<int>(), p2s = new List<int>();
                for (int i = 0; i < 15; i += 3)
                {
                    p1v.Add(v[c[i]]);
                    p2v.Add(v[c[i + 15]]);
                    p1s.Add(s[c[i + 1]]);
                    p2s.Add(s[c[i + 16]]);
                }
                p1Id = Comb(p1v, p1s, 109);
                p2Id = Comb(p2v, p2s, 109);
                while (p1Id == p2Id)
                {
                    p1Id = Comb(p1v, p1s, max);
                    p2Id = Comb(p2v, p2s, max);
                    max--;
                }
                if (p1Id > p2Id) ret++;
            }
            return ret;
        }

        private static int Comb(List<int> v, List<int> s, int max)
        {
            v.Sort();
            if (max > 100)
            {
                int i, j, k, l, c;
                if (max > 104 && s[0].Equals(s[1]) && s[0].Equals(s[2]) && s[0].Equals(s[3]) && s[0].Equals(s[4]))
                {
                    if (max > 108 && v[0].Equals(10) && v[1].Equals(11) && v[2].Equals(12) && v[3].Equals(13) && v[4].Equals(14)) return 109;
                    if (max > 107 && v[0].Equals(v[1] - 1) && v[1].Equals(v[2] - 1) && v[2].Equals(v[3] - 1) && v[3].Equals(v[4] - 1)) return 108;
                    if (max > 104) return 105;
                }
                if (max > 101)
                {
                    for (i = 0; i < 5; i++)
                    {
                        c = 0;
                        for (j = 0; j < 5; j++) if (v[i].Equals(v[j])) c++;
                        if (c == 4 && max > 106) return 107;
                        if (c == 3 && max > 102) return 70 + v[i];
                        else if (c == 2 && max > 101)
                        {
                            for (k = 0; k < 5; k++)
                            {
                                if (v[k].Equals(v[i])) continue;
                                c = 0;
                                for (l = 0; l < 5; l++) if (v[k].Equals(v[l])) c++;
                                if (c == 2) return 50 + v[i];
                            }
                        }
                    }
                }
                if (max > 103 && v[0].Equals(v[1] - 1) && v[1].Equals(v[2] - 1) && v[2].Equals(v[3] - 1) && v[3].Equals(v[4] - 1)) return 104;
                if (max > 100)
                {
                    for (i = 0; i < 5; i++)
                    {
                        c = 0;
                        for (j = 0; j < 5; j++) if (v[i].Equals(v[j])) c++;
                        if (c == 2) return 30 + v[i];
                    }
                }
            }
            int r = 4;
            while (v[r] > max) r--;
            return v[r];
        }
    }
}
