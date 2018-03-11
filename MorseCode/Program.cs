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
            string inputPhase = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Output: ");

            string output;

            // IF input phrase contains at least one of known morse letters
            if (MorseCode.morse.Values.Any(morseLetter => inputPhase.Contains(morseLetter)))
            {
                output = MorseCode.Decode(inputPhase);
            }
            else
            {
                output = MorseCode.Encode(inputPhase);
            }

            Console.WriteLine(output);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
