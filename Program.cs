using System;

namespace guessNumberGame {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine("Welcome to Alphonsus' Guessing Game!");

            Console.WriteLine("Select your Level : E = Easy , M = Medium , H = Hard");
            string userSelect = Console.ReadLine ();

            if (userSelect == "E") {
                try {
                    Random random = new Random ();  
                    int randomNumber = random.Next (1, 11);
                    int guess = 0;
                    int numberOfGuess = 6;
                    bool gameOver = false;

                    Console.WriteLine("Easy Mode: Select number between 1 to 10, You have 6 Guess Chances: .....Goodluck");    

                    while (gameOver == false) {
                        guess = Convert.ToInt32(Console.ReadLine());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) {
                            Console.WriteLine("You've used up Your 6 Guess chances....GAME OVER!!");
                            gameOver = true;
                        } else if (guess == randomNumber) {
                            Console.WriteLine("You are correct!");
                            gameOver = true;
                        } else if (guess != randomNumber) {
                            Console.WriteLine("You are wrong!");
                        } 
                    }
                    Console.ReadLine();
                } catch (FormatException) {
                    Console.WriteLine("Wrong Input... PLEASE ENTER A NUMBER.");
                }

            } else if (userSelect == "M") {
                try { 
                    Random random = new Random ();  
                    int randomNumber = random.Next (1, 21);
                    int guess = 0;
                    int numberOfGuess = 4;
                    bool gameOver = false;

                    Console.WriteLine ("Medium Mode: Select number between 1 to 20, You have 4 Guess Chances: .....Goodluck");    

                    while (gameOver == false) {
                        guess = Convert.ToInt32(Console.ReadLine());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) {
                            Console.WriteLine("You've used up Your 4 Guess chances....GAME OVER!!");
                            gameOver = true;
                        } else if (guess == randomNumber) {
                            Console.WriteLine("You are correct!");
                            gameOver = true;
                        } else if (guess != randomNumber) {
                            Console.WriteLine("You are wrong!");
                        } 
                    }
                    Console.ReadLine();
                } catch (FormatException) {
                    Console.WriteLine("Wrong Input... PLEASE ENTER A NUMBER.");
                }

            } else if (userSelect == "H") {
                try {
                    Random random = new Random ();  
                    int randomNumber = random.Next (1, 51);
                    int guess = 0;
                    int numberOfGuess = 3;
                    bool gameOver = false;

                    Console.WriteLine ("Hard Mode: Select number between 1 to 50, You have 3 Guess Chances: .....Goodluck");    

                    while (gameOver == false) {
                        guess = Convert.ToInt32(Console.ReadLine ());
                        numberOfGuess--;

                        if (guess != randomNumber && numberOfGuess == 0) {
                            Console.WriteLine("You've used up Your 3 Guess chances....GAME OVER!!");
                            gameOver = true;
                        } else if (guess == randomNumber) {
                            Console.WriteLine("You are correct!");
                            gameOver = true;
                        } else if (guess != randomNumber) {
                            Console.WriteLine("You are wrong!");
                        } 
                    }
                    Console.ReadLine();
                } catch (FormatException) {
                    Console.WriteLine("Wrong Input... PLEASE ENTER A NUMBER.");
                }
                }
            } 
    }    }   
                    
