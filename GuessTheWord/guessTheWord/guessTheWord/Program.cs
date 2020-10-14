using System;

namespace guessTheWord
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "cenas";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.Write("You LOSE!");
            }
            else
            {
                Console.Write("You Win, the scret word was: " + secretWord);
            }
            




        }
    }
}
