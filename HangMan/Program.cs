using System;
using System.Collections.Generic;
using System.Linq;

namespace HangMan
{
    class Program
    {
        static private protected Dictionary<string, int> randomWord = new Dictionary<string, int>()
    {
          { "shockingly", 1 },
          { "humanizers", 2 },
          { "hypocrites", 3 },
          { "brutalized", 4 },
          { "blueprints", 5 },
          { "abductions", 6 },
          { "nightmares", 7 },
          { "hospitable", 8 },
          { "destroying", 9 },
          { "complaints", 10 }

    };
        public static char[] WordToChar(string word)
        {
            char[] charArr = word.ToCharArray();
            foreach (char ch in charArr)
            {

                Console.WriteLine(ch);
            }
            return charArr;
        }
        static void Main(string[] args)
        {
            

            Console.WriteLine(myValue);



        }
    }
}
