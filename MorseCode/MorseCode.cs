using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseCode
    {
        public static readonly Dictionary<string, string> morse = new Dictionary<string, string>()
        {
            {"A", ".-"},
            {"B", "-..."},
            {"C", "-.-."},
            {"D", "-.."},
            {"E", "."},
            {"F", "..-."},
            {"G", "--."},
            {"H", "...."},
            {"I", ".."},
            {"J", ".---"},
            {"K", "-.-"},
            {"L", ".-.."},
            {"M", "--"},
            {"N", "-."},
            {"O", "---"},
            {"P", ".--."},
            {"Q", "--.-"},
            {"R", ".-."},
            {"S", "..."},
            {"T", "-"},
            {"U", "..-"},
            {"V", "...-"},
            {"W", ".--"},
            {"X", "-..-"},
            {"Y", "-.--"},
            {"Z", "--.."},
            {"0", "-----"},
            {"1", ".----"},
            {"2", "..---"},
            {"3", "...--"},
            {"4", "....-"},
            {"5", "....."},
            {"6", "-...."},
            {"7", "--..."},
            {"8", "---.."},
            {"9", "----."},
        };

        public static string EncodeChar(char letter)
        {
            string letterAsString = letter.ToString();
            if (morse.Keys.Any(key => key.Equals(letterAsString, StringComparison.OrdinalIgnoreCase)))
            {
                return morse[letterAsString.ToUpperInvariant()];
            }

            return "<unsupported latin letter>";
        }


        public static string Encode(string inputPhrase)
        {
            string encodedPhrase = "";
            foreach (char letter in inputPhrase)
            {
                encodedPhrase = encodedPhrase + ' ' + EncodeChar(letter);
            }

            return encodedPhrase;
        }

        public static string Decode(string encodedPhrase)
        {
            string decodedPhrase = "";
            string[] encodedLetters = encodedPhrase.Split(' ');
            foreach (string encodedLetter in encodedLetters)
            {
                decodedPhrase = decodedPhrase + DecodeLetter(encodedLetter);
            }

            return decodedPhrase;
        }

        public static string DecodeLetter(string encodedLetter)
        {
            foreach (KeyValuePair<string, string> row in morse)
            {
                if (row.Value.Equals(encodedLetter))
                {
                    return row.Key;
                }
            }

            return "<unknown morse letter>";
        }
    }
}
