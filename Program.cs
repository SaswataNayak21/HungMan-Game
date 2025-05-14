using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANGMAN_GAME
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            string word = "savehim";

            int maxlives = 7;
            int currentlives = maxlives;

            bool win = false;

            List<char> guessedletters = new List<char>();

            while (currentlives > 0 && !win)
            {
                foreach (char c in word)
                {
                    if (guessedletters.Contains(c))
                        Console.Write(c);
                    else
                        Console.Write("_");
                }
                Console.WriteLine("\n Please guess a letter!");
                Console.WriteLine(currentlives + "/" + maxlives + "lives remaining.");
                char guess = Convert.ToChar(Console.ReadLine());

                if (word.Contains(guess) && !guessedletters.Contains(guess))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                    currentlives--;

                }
                guessedletters.Add(guess);

                bool wordcomplete = true;

                foreach (char c in word)
                {
                    if (!guessedletters.Contains(c))
                        wordcomplete = false;

                    win = wordcomplete;

                }
            }
            if (win)
                Console.WriteLine("Congratulations, You win!");
            else
                Console.WriteLine("You lose !");

        }
    }
}
