using System.ComponentModel.Design;

namespace Maori_Quiz
{
    internal class Program
    {
        static int score = 0;
        static int level = 0;
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Welcome to Mark's Maori Quiz");
            //adding a delay between the text
            Thread.Sleep(1000);
            //prompting the user for their name
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            //adding a delay between the text
            Thread.Sleep(1000);
            //will repeat until the user inputs 1,2 or 3
            while (level != 1 && level != 2 && level != 3)
            {
                Console.WriteLine($"Hi {name}, please enter what level you would like to play\n1. Easy\n2. Medium\n3. Hard");
                level = Convert.ToInt32(Console.ReadLine());
            }
            if(level == 1)
            {
                Level1();
            }
            else if(level == 2)
            {

            }
            else if (level == 3)
            {

            }

            //level 1 method
            static void Level1()
            {
                // 
                string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;
                string a1 = "kia ora";
                string a2 = "moana";
                string a3 = "come here";
                string a4 = "kai";
                string a5 = "work";
                string a6 = "tamariki";
                string a7 = "family";
                string a8 = "mornea";
                string a9 = "yellow";
                string a10 = "blue";
                
                // QUESTION 1

                Console.WriteLine("Question 1: How do you say \"hello\"\na. ka kite\nb. noho iho\nc. kia ora");
                q1 = Console.ReadLine().ToLower();
                if(q1 == "c")
                {
                    Console.WriteLine("Good job you got it right!");
                    score += 1;
                }
                else
                {
                    Console.WriteLine("Try again");
                    q1 = Console.ReadLine();
                    if(q1 == "c")
                    {
                        Console.WriteLine("You got it on you're second try. You don't get any points though.");
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, the correct answer was " + a1);
                    }
                }
                // QUESTION 2

                Console.WriteLine("Question 2: How do you say \"Ocean\"\na. maoana\nb. awa\nc. katao");
                q2 = Console.ReadLine().ToLower();
                if (q2 == "a")
                {
                    Console.WriteLine("Good job you got it right!");
                    score += 1;
                }
                else
                {
                    Console.WriteLine("Try again");
                    q2 = Console.ReadLine();
                    if (q2 == "a")
                    {
                        Console.WriteLine("You got it on you're second try. You don't get any points though.");
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, the correct answer was " + a2);
                    }
                }
                // QUESTION 3
                Console.WriteLine("Question 3: What does \"haere mai\" mean\na. congratulations\nb. go away\nc. come here");
                q3 = Console.ReadLine().ToLower();
                if (q3 == "c")
                {
                    Console.WriteLine("Good job you got it right!");
                    score += 1;
                }
                else
                {
                    Console.WriteLine("Try again");
                    q3 = Console.ReadLine();
                    if (q3 == "c")
                    {
                        Console.WriteLine("You got it on you're second try. You don't get any points though.");
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, the correct answer was " + a3);
                    }
                }
                // QUESTION 4 

                Console.WriteLine("Question 2: How do you say \"Food\"\na. waka\nb. ika\nc. kai");
                q4 = Console.ReadLine().ToLower();
                if (q4 == "c")
                {
                    Console.WriteLine("Good job you got it right!");
                    score += 1;
                }
                else
                {
                    Console.WriteLine("Try again");
                    q4 = Console.ReadLine();
                    if (q4 == "c")
                    {
                        Console.WriteLine("You got it on you're second try. You don't get any points though.");
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, the correct answer was " + a4);
                    }
                }
                //QUESTION 5

                Console.WriteLine("Question 5: What does \"mahi\" mean\na. weclome\nb. work\nc. visitors");
                q5 = Console.ReadLine().ToLower();
                if (q5 == "b")
                {
                    Console.WriteLine("Good job you got it right!");
                    score += 1;
                }
                else
                {
                    Console.WriteLine("Try again");
                    q5 = Console.ReadLine();
                    if (q5 == "c")
                    {
                        Console.WriteLine("You got it on you're second try. You don't get any points though.");
                    }
                    else
                    {
                        Console.WriteLine("Unlucky, the correct answer was " + a5);
                    }
                }
            }
        }

    }
}