using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**** Fun with Morse Code ****");

            Console.Write("Input: ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine();
            Console.Write("Output: ");

            Dictionary<char, string> morse = new Dictionary<char, string>() {
                {'A', ".-"},
                {'B', "-..."},
                {'C', "-.-."},
                {'D', "-.."},
                {'E', "."},
                {'F', "..-."},
                {'G', "--."},
                {'H', "...."},
                {'I', ".."},
                {'J', ".---"},
                {'K', "-.-"},
                {'L', ".-.."},
                {'M', "--"},
                {'N', "-."},
                {'O', "---"},
                {'P', ".--."},
                {'Q', "--.-"},
                {'R', ".-."},
                {'S', "..."},
                {'T', "-"},
                {'U', "..-"},
                {'V', "...-"},
                {'W', ".--"},
                {'X', "-..-"},
                {'Y', "-.--"},
                {'Z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
            };

            for (int i = 0; i < input.Length; i++)
            {
                
                char c = input[i];
                if (morse.ContainsKey(c))
                {
                    Console.Write(morse[c]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
