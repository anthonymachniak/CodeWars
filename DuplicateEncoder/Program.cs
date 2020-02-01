using System;
using System.Collections.Generic;
using System.Text;

namespace DuplicateEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var letterCount = new Dictionary<char, int>();

            args[0] = args[0].ToLower();
            foreach(var letter in args[0])
            {
                if(letterCount.ContainsKey(letter))
                {
                    letterCount[letter]++;
                }
                else
                {
                    letterCount.Add(letter, 1);
                }
            }

            var alteredWord = string.Empty;
            foreach(var letter in args[0])
            {
                if(letterCount[letter] > 1)
                {
                    alteredWord += ")";
                }
                else
                {
                    alteredWord += "(";
                }
            }

            Console.WriteLine(alteredWord);
        }
    }
}
