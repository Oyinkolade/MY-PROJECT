using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                int score = 0;
                int totalQuestions = 5;

                //Give the user instructions that would guide them
                Console.WriteLine("In this quiz you must answer either True or False");
            Console.WriteLine("Which subject do you want to attempt (Science, Math, English)?");
            var Response = Console.ReadLine();

            // Create an array of science questions
            string[] SciQue = new string[5];
            SciQue[0] = "1. Solid is a state of matter";
            SciQue[1] = "2. Chemistry is a branch under science";
            SciQue[2] = "3. Humans have more than two lungs";
            SciQue[3] = "4. Biology is a branch under science";
            SciQue[4] = "5. The Earth is the center of the solar system";
            //  Check if what the user picks is Science
            if (Response == "Science") {
                Console.WriteLine(SciQue[0]);
                var SciAns = Console.ReadLine();
                if (SciAns == "True")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(SciQue[1]);
                SciAns = Console.ReadLine();
                if (SciAns == "True")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(SciQue[2]);
                SciAns = Console.ReadLine();
                if (SciAns == "False")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(SciQue[3]);
                SciAns = Console.ReadLine();
                if (SciAns == "True")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(SciQue[4]);
                 SciAns = Console.ReadLine();
                if (SciAns == "False")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

            }
                // Create an array of math questions
                string[] MathQue = new string[5];
            MathQue[0] = "1. The sum of angles in a triangle is always 180 degrees";
            MathQue[1] = "2. Zero is considered an even number";
            MathQue[2] = "3. The square root of 36 is 6";
            MathQue[3] = "4. The sum of 12 and 5 is 20";
            MathQue[4] = "5. The number 15 is a prime number";

                //  Check if what the user picks is Math
                if (Response == "Math")
            {
                Console.WriteLine(MathQue[0]);
                var MathAns = Console.ReadLine();
                if (MathAns == "True")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(MathQue[1]);
                MathAns = Console.ReadLine();
                if (MathAns == "True")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(MathQue[2]);
                MathAns = Console.ReadLine();
                if (MathAns == "True")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(MathQue[3]);
                MathAns = Console.ReadLine();
                if (MathAns == "False")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }

                Console.WriteLine(MathQue[4]);
                MathAns = Console.ReadLine();
                if (MathAns == "False")
                {
                    Console.WriteLine("You are correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("You are wrong");
                }
            }
                // Create an array of English questions
                string[] EngQue = new string[5];
            EngQue[0] = "1. The English alphabet has 30 letters";
            EngQue[1] = "2. There are 32 vowels in the English alphabet";
            EngQue[2] = "3. The English alphabet contains 24 letters";
            EngQue[3] = "4.  A verb is a word that represents an action or a state of being";
            EngQue[4] = "5. Adjectives describe or modify nouns";

                //  Check if what the user picks is English
                if (Response == "English")
                {
                    Console.WriteLine(EngQue[0]);
                    var EngAns = Console.ReadLine();
                    if (EngAns == "False")
                    {
                        Console.WriteLine("You are correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are wrong");
                    }

                    Console.WriteLine(EngQue[1]);
                    EngAns = Console.ReadLine();
                    if (EngAns == "False")
                    {
                        Console.WriteLine("You are correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are wrong");
                    }

                    Console.WriteLine(EngQue[2]);
                    EngAns = Console.ReadLine();
                    if (EngAns == "False")
                    {
                        Console.WriteLine("You are correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are wrong");
                    }

                    Console.WriteLine(EngQue[3]);
                    EngAns = Console.ReadLine();
                    if (EngAns == "True")
                    {
                        Console.WriteLine("You are correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are wrong");
                    }

                    Console.WriteLine(EngQue[4]);
                    EngAns = Console.ReadLine();
                    if (EngAns == "True")
                    {
                        Console.WriteLine("You are correct");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("You are wrong");
                    }
                }
                Console.WriteLine("Quiz Over!");
                Console.WriteLine("You scored " + score + " out of " + totalQuestions + ".");

                if (score == totalQuestions)
                {
                    Console.WriteLine("Excellent! You got all answers correct.");
                }
                else if (score >= totalQuestions / 2)
                {
                    Console.WriteLine("Good job! You answered more than half of the questions correctly.");
                }
                else
                {
                    Console.WriteLine("Keep practicing! You'll improve next time.");
                }
                Console.WriteLine("Do you want to try again? (yes/no)");
                var repeat_response = Console.ReadLine();
                if (repeat_response == "no")
                {
                    repeat = false;
                    Console.WriteLine("Thank you for attempting this quiz");
                }
            }
        }
    }
}
