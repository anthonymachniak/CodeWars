using System;
using System.Collections.Generic;

namespace PersistentBugger
{
    class Program
    {
        public static void Main(string[] args)
        //public static int Main(long baseNumber)
        {
            long baseNumber = long.Parse(args[0]);
            int persistence = 0;

            while(baseNumber.ToString().Length != 1)
            {
                List<int> multiplicationList = new List<int>();
                foreach(var digit in baseNumber.ToString())
                {
                    multiplicationList.Add(int.Parse(digit.ToString()));
                }

                var result = 1;
                foreach(var value in multiplicationList)
                {
                    result *= value;
                }

                baseNumber = result;
                persistence++;
            }

            Console.WriteLine(persistence);
        }
    }
}
