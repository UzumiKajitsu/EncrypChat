using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class CaesarCipher
    {
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char baseChar = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch - baseChar) + key) % 26) + baseChar);
        }

        public static string Encipher(string input, int key)
        {
            StringBuilder output = new StringBuilder();

            foreach (char ch in input)
            {
                output.Append(Cipher(ch, key));
            }

            return output.ToString();
        }

        
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - (key % 26));
        }
    }
}
