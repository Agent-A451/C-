using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type E for Easy, M for Medium, H for Hard");
            string level = Console.ReadLine();
            
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int Guess;
            int numGuesses = 6;
            bool gameOver = false;

            Console.WriteLine("Can you guess the number I'm thinking of?");

            while (gameOver == false)
            {
                Guess = Convert.ToInt32(Console.ReadLine());
                numGuesses--;

                if (Guess != randomNumber && numGuesses == 0)
                {
                    Console.WriteLine("You got it wrong!");
                    gameOver = true;
                }
                else if (Guess == randomNumber)
                {
                    Console.WriteLine("You got it right!");
                    gameOver = true;
                }
            }
        }
    }
}        