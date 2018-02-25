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

            Console.WriteLine("**** Fun with Morse Code *****");

            Console.Write("Input: ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine("Output: ");

            Dictionary<char, string> morse = new Dictionary<char, string>();
            morse.Add('A', ".-");
            morse.Add('B', "-...");

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (morse.ContainsKey(c))
                {
                    Console.Write(morse[c]);
                }
            }

            Console.ReadLine();

        }
    }
}
