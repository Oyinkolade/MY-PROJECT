using System;
using System.Collections.Generic;

namespace Guessing_Game_2
{
    // Create a class with relatable attributes
    public class Game
    {
        // Attribute 1
        public int RandomNumber { get; set; }

        // Attribute 2
        public int response { get; set; }

        // Attribute 3
        public string Levels { get; set; }

        // Attribute 4
        public List<int> listOfResponses { get; set; }

        // Attribute 5
        public bool playAgain { get; set; }

        public Game()
        {
            listOfResponses = new List<int>();
        }

        // Recursive method to handle the game logic
        public Game GuessNumber()
        {
            // Ask for user input (guess)
            Console.WriteLine("Enter your guess:");

            // Collect the user's response
            this.response = Convert.ToInt32(Console.ReadLine());

            // Add the response to the list
            this.listOfResponses.Add(this.response);

            // Compare response to RandomNumber
            if (this.response < this.RandomNumber)
            {
                Console.WriteLine("Too Low");
                // The Recursive method is call if the guess is incorrect
                return GuessNumber();
            }
            else if (this.response > this.RandomNumber)
            {
                Console.WriteLine("Too High");
                // The Recursive method is call if the guess is incorrect
                return GuessNumber();
            }
            else
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("\nYour guesses were:");
                for (int i = 0; i < this.listOfResponses.Count; i++)
                {
                    Console.WriteLine(this.listOfResponses[i]);
                }
                return this;
            }
        }

        // Use a method that runs all the code for you
        public Game GetGame()
        {
            // Set RandomNumber based on level, also give an instruction for each level
            Random r = new Random();
            if (this.Levels == "Level 1")
            {
                Console.WriteLine("Guess a number between 1 to 101");
                this.RandomNumber = r.Next(1, 101);
            }
            else if (this.Levels == "Level 2")
            {
                Console.WriteLine("Guess a number between 1 to 301");
                this.RandomNumber = r.Next(1, 301);
            }
            else if (this.Levels == "Level 3")
            {
                Console.WriteLine("Guess a number between 1 to 501");
                this.RandomNumber = r.Next(1, 501);
            }

            return GuessNumber();
        }
    }
}
