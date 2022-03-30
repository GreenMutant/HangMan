using System;
using System.Text;

namespace HangMan
{
    class Program
    {
        
        public static string GetRandomWord(string randomWord)
        { 
            string[] secretArr = new String[10]
               {
                    "shockingly", "humanizers", "hypocrites" , "brutalized", "blueprints",
                    "abductions", "nightmares", "hospitable", "destroying", "complaints"
               };

            Random r = new Random();
            int rInt = r.Next(1, 10);

            randomWord = secretArr[rInt];

            return randomWord;
        }
            static void Main(string[] args)
        {
            int lives = 11;
            bool exist = false;
            string val;
            string line = "-";
            string space = " ";
            string incorrect;
            string secretWord = null;
            char character;
            char lineChar;
            char spaceChar;
            char[] hiddenArr = new char[19];

            StringBuilder incorrectChars = new StringBuilder(10).AppendLine();

            do
                {
                if (lives > 10)
                {
                    Console.WriteLine("HangMan 1.0");
                    Console.WriteLine("Start (enter)");

                    lineChar = char.Parse(line);
                    spaceChar = char.Parse(space);

                    for (int i = 0; i < hiddenArr.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            hiddenArr[i] = lineChar;
                        }
                        else
                        {
                            hiddenArr[i] = spaceChar;
                        }
                    }
                    secretWord = GetRandomWord(secretWord);
                    val = Console.ReadLine();
                    lives--;
                }

                if (lives < 11)
                {

                    Console.Clear();
                    Console.WriteLine(lives + " lives");

                    if (lives == 10)
                    {
                        Console.WriteLine("\n");
                    }
                        if (lives < 10)
                    {
                        Console.WriteLine("incorrect characters: " + incorrectChars.ToString());
                    }

                    Console.WriteLine("\n");
                    foreach (char ch in hiddenArr)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine("\n");

                    Console.WriteLine("Character(c) - Word(w) - Exit (0):");
                    val = Console.ReadLine();
                    
                    if (val == "0")
                    {
                        lives = 0;
                    }

                    if (val == "c")
                    { 
                        Console.WriteLine("choose Character:"); 
                        val = Console.ReadLine();
                        incorrect = incorrectChars.ToString();
                        if (incorrect.Contains(val))
                        {
                            Console.WriteLine("Character Allready Tried - Try Again (Enter)");
                            val = Console.ReadLine();
                            exist = true;
                            lives++;
                        }
                        
                        if (secretWord.Contains(val) && (exist == false))
                        {
                            
                            int arrNR = secretWord.IndexOf(val);
                            if (arrNR > 0)
                            {
                                arrNR = ((arrNR * 2));
                            }
                            character = char.Parse(val);
                            hiddenArr[arrNR] = character;
                            Console.WriteLine("Exists - Try Again (Enter)");
                            val = Console.ReadLine();

                            lives++;
                        }

                        else
                        {
                            if (exist == false)
                            {
                                incorrectChars.Append(val + " ");
                                val = null;
                                Console.WriteLine("Incorrect - Try Again (Enter)");
                                val = Console.ReadLine();
                            }
                        }
                        exist = false;
                    }

                    if (val == "w")
                    {
                        Console.WriteLine("write Word:");
                        val = Console.ReadLine();

                        if (val != secretWord)
                        {
                            Console.WriteLine("Incorrect - Try Again (Enter)");
                            val = Console.ReadLine();
                        }

                        if (val == secretWord)
                        {
                            Console.WriteLine("You Won! New Game (enter) - Exit (0)");
                            val = Console.ReadLine();
                            Console.Clear();
                            lives = 12;

                            

                        }
                            if (val == "0")

                        {
                            lives = 0;
                        }
                    }

                    lives--;
                } 
                
            }
            while (lives > 0);

            Console.WriteLine("- Game Over -");

            Environment.Exit(0);

        }
    }
}

