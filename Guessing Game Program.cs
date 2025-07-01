using System;

namespace Guessing_Game_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Game class
            Game game = new Game();

            // Set playAgain to true to start the game loop
            game.playAgain = true;

            while (game.playAgain)
            {
                // Ask the user which level they want to play
                Console.WriteLine("Which Level do you want to attempt {Level 1, Level 2, or Level 3}");

                // Collect the level the user wants to play
                game.Levels = Console.ReadLine();

                // Call the GetGame method to start the game based on the chosen level
                game.GetGame();

                // Ask the user if they want to play again
                Console.WriteLine("Do you want to play again (yes/no)");

                // Collect the response to play again
                string playAgainResponse = Console.ReadLine();

                // If the user says no, set playAgain to false, ending the game loop
                if (playAgainResponse == "no")
                {
                    game.playAgain = false;
                    Console.WriteLine("Thanks for playing the game!");
                }
            }
        }
    }
}