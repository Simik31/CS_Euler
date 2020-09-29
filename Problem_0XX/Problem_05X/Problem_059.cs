using System.Collections.Generic;
using System.Text;

/*
DATA: https://projecteuler.net/project/resources/p059_cipher.txt
Each character on a computer is assigned a unique code and the preferred standard is ASCII (American Standard Code for Information Interchange). For example, uppercase A = 65, asterisk (*) = 42, and lowercase k = 107.
A modern encryption method is to take a text file, convert the bytes to ASCII, then XOR each byte with a given value, taken from a secret key. The advantage with the XOR function is that using the same encryption key on the cipher text, restores the plain text; for example, 65 XOR 42 = 107, then 107 XOR 42 = 65.
For unbreakable encryption, the key is the same length as the plain text message, and the key is made up of random bytes. The user would keep the encrypted message and the encryption key in different locations, and without both "halves", it is impossible to decrypt the message.
Unfortunately, this method is impractical for most users, so the modified method is to use a password as a key. If the password is shorter than the message, which is likely, the key is repeated cyclically throughout the message. The balance for this method is using a sufficiently long password key for security, but short enough to be memorable.
Your task has been made easy, as the encryption key consists of three lower case characters. Using p059_cipher.txt (right click and 'Save Link/Target As...'), a file containing the encrypted ASCII codes, and the knowledge that the plain text must contain common English words, decrypt the message and find the sum of the ASCII values in the original text.
*/

namespace cs_euler
{
    public class Problem_059 : IProblem
    {
        public long Run()
        {
            string[] f = Reader.File(59);
            List<int> e = new List<int>();
            foreach (string l in f) foreach (string c in l.Split(",")) e.Add(int.Parse(c));
            string s = "";
            long r = 0;
            for (int i = 97; i < 123 && s.Equals(""); i++)
            {
                for (int j = 97; j < 123 && s.Equals(""); j++)
                {
                    for (int k = 97; k < 123 && s.Equals(""); k++)
                    {
                        StringBuilder t = new StringBuilder();
                        for (int l = 0; l < e.Count; l++)
                        {
                            if (l % 3 == 0) t.Append((char)(e[l] ^ i));
                            else if (l % 3 == 1) t.Append((char)(e[l] ^ j));
                            else t.Append((char)(e[l] ^ k));
                        }
                        if (t.ToString().Contains(" the ")) s = t.ToString();
                    }
                }
            }
            foreach (char c in s.ToCharArray()) r += c;
            return r;
        }
    }
}
