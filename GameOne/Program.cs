using System;

namespace GameOne
{
    class Program
    {

        static void Main(string[] args)
        {
            //Trivia questions using IF, Else statements

            string answer1 = "a";
            string answer2 = "c";
            string answer3 = "b";
            string answer4 = "false";
            string userInput1;
            string userInput2;
            string userInput3;
            string userInput4;
             
            int correctAnswers = 0;


            Console.Title = "Trivia";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome To Trivia!");

            
            //first question
            Console.WriteLine("What is the capital of North Carolina?");
            Console.WriteLine("a.Raleigh");
            Console.WriteLine("b.Charlotte");
            Console.WriteLine("c.Greensboro");

            Console.ForegroundColor = ConsoleColor.White;
            userInput1 = Console.ReadLine();
            if(userInput1 == answer1) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                correctAnswers++;//correctAnswers integer will display correct answer by adding 1 on to each correct answer

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong! The correct answer is {0}", answer1);
            }

            Console.WriteLine();

            //second question
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How many superbowls have the New England Patriots won?");
            Console.WriteLine("a.0");
            Console.WriteLine("b.3");
            Console.WriteLine("c.5");

            Console.ForegroundColor = ConsoleColor.White;
            userInput2 = Console.ReadLine();
            if (userInput2 == answer2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!The correct answer is {0}", answer2);
            }
            Console.WriteLine();

            //third question
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("what top rated beer is Russian River Brewing famous for?");
            Console.WriteLine("a.Two Hearted Ale");
            Console.WriteLine("b.Pliny the Elder");
            Console.WriteLine("c.Skillet Donut Stout");

            Console.ForegroundColor = ConsoleColor.White;
            userInput3 = Console.ReadLine();
            
            if (userInput3 == answer3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong! The correct answer is {0}", answer3);
            }
            Console.WriteLine();
           

            //fourth question
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Sun is Green");
            Console.WriteLine("true");
            Console.WriteLine("false");
            

            Console.ForegroundColor = ConsoleColor.White;
            userInput4 = Console.ReadLine();

            if (userInput4 == answer4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong! The correct answer is {0}", answer4);
            }
            Console.WriteLine();





            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Way to go!, you got {0} correct", correctAnswers);
            Console.ReadKey();
        }
    }
}