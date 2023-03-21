using System.ComponentModel.Design;
using System.Data;

namespace Maori_Quiz

{
    internal class Program
    {
        static int score = 0;
        static int level = 0;
        static string name;
        static char playAgain;
        static bool loop = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mark's Maori Quiz");
            //adding a delay between the text
            Thread.Sleep(1000);
            //prompting the user for their name
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            //adding a delay between the text
            Thread.Sleep(1000);
            //will repeat until the user inputs 1,2 or 3
            while(loop == true)
            {
                while (level != 1 && level != 2 && level != 3)
                {
                    score = 0;
                    level = 0;
                    Console.WriteLine($"Hi {name}, please enter what level you would like to play\n1. Easy\n2. Medium\n3. Hard");
                    level = Convert.ToInt32(Console.ReadLine());
                }
                if (level == 1)
                {
                    levelEasy();
                }
                else if (level == 2)
                {

                }
                else if (level == 3)
                {

                }

                //level 1 method
                static void levelEasy()
                {
                    // 
                    string[] question = {
                    "How do you say \"hello\"\na. ka kite\nb. noho iho\nc. kia ora",
                    "How do you say \"ocean\"\na. maoana\nb. awa\nc. katao ",
                    "What does \"haere mai\" mean\na. congratulations\nb. go away\nc. come here",
                    "How do you say \"food\"\na. waka\nb. ika\nc. kai",
                    "What does \"mahi\" mean\na. weclome\nb. work\nc. visitors",
                    "How do you say \"children\"\na. tamariki\nb. tamahine\nc. toanga",
                    "What does \"whanau\" mean\na. parents\nb. hill\nc. family",
                    "How do you say \"good morning\"\na. tena koutou\nb. morena\nc. haere ra",
                    "What colour is Kowhai\na. blue\nb. red\nc. yellow",
                    "What colour is Kikorangi\na. red\nb. blue\nc. orange"};

                    string[] answer = { "kia ora", "moana", "come here", "kai", "work", "tamariki", "family", "mornea", "yellow", "blue" };
                    string[] charAnswer = { "c", "a", "c", "c", "b", "a", "c", "b", "c", "b" };
                    string userInput;

                    //clearing the console, prompting the user what level they selected and adding delays between the messages
                    Console.Clear();
                    Console.WriteLine("You selected the easy level!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Get ready!");
                    Thread.Sleep(1000);
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Question {i + 1}:" + question[i]);
                        //getting input from the user
                        userInput = Console.ReadLine().ToLower();
                        //checking if the user has answered correctly 
                        if (userInput == charAnswer[i])
                        {
                            Console.WriteLine("Good job you got it right!");
                            score += 1;
                        }
                        else
                        {
                            //giving the user a second chance 
                            Console.WriteLine("Try again");
                            userInput = Console.ReadLine();
                            if (userInput == charAnswer[i])
                            {
                                Console.WriteLine("You got it on you're second try. You don't get any points though.");
                            }
                            else
                            {
                                Console.WriteLine("Unlucky, the correct answer was " + answer[i]);
                            }
                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    if (score <= 3)
                    {
                        Console.WriteLine($"Hard luck your score is {score}, would you like to play again?(y / n)");
                    }
                    else if (score <= 6)
                    {
                        Console.WriteLine($"Not to bad your score is {score}, would you like to play again?(y / n)");
                    }
                    else
                    {
                        Console.WriteLine($"Great job! Your score is {score} would you like to play again?(y / n)");
                    }
                    playAgain = Convert.ToChar(Console.ReadLine().ToLower());
                    if (playAgain == 'n')
                    {
                        Console.WriteLine("Thanks for playing!");
                        loop = false; 
                    }
                }
            
            }
        }
    }
}

