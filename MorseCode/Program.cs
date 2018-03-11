using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        private static Dictionary<string, string> morse = new Dictionary<string, string>() {
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

        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Morse Code ****");

            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Output: ");           

            for (int i = 0; i < input.Length; i++)
            {                
                string c = input[i].ToString();
                if (morse.Keys.Any(key => key.Equals(c, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.Write(morse[c.ToUpperInvariant()]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
