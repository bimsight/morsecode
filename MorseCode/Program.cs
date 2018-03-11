﻿using System;
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

            MorseCode m = new MorseCode();
            Console.WriteLine(m.Encode(inputPhase));

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
