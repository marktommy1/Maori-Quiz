
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
                    Console.WriteLine("Would you like to play again?(y / n)");
                    playAgain = Convert.ToChar(Console.ReadLine().ToLower());
                    if (playAgain == 'n')
                    {
                        Console.WriteLine("Thanks for playing!");
                        loop = false;
                    }
                }
                else if (level == 2)
                {
                    levelMedium();
                }
                else if (level == 3)
                {

                }

                //level 1 method
                static void levelEasy()
                {
                    // 
                    string[] question = {
                    "How do you say \"hello\"in Maori?\na. ka kite\nb. noho iho\nc. kia ora",
                    "How do you say \"ocean\"in Maori?\na. maoana\nb. awa\nc. katao ",
                    "What does \"haere mai\" mean in Maori?\na. congratulations\nb. go away\nc. come here",
                    "How do you say \"food\"in Maori?\na. waka\nb. ika\nc. kai",
                    "What does \"mahi\" mean in Maori?\na. weclome\nb. work\nc. visitors",
                    "How do you say \"children\"in Maori?\na. tamariki\nb. tamahine\nc. toanga",
                    "What does \"whanau\" mean in Maori?\na. parents\nb. hill\nc. family",
                    "How do you say \"good morning\"in Maori\na. tena koutou\nb. morena\nc. haere ra",
                    "What colour is \"Kowhai\"?\na. blue\nb. red\nc. yellow",
                    "What colour is \"Kikorang\"i?\na. red\nb. blue\nc. orange"};

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
                        Console.WriteLine($"Hard luck your score is {score}");
                    }
                    else if (score <= 6)
                    {
                        Console.WriteLine($"Not to bad your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine($"Great job! Your score is {score}");
                    }

                //MEDIUM LEVEL
                }
                static void levelMedium()
                {
                    // declaring all of the questions and answers in arrays
                    string[] question = {
                    "How do you say \"I love you\"in Maori?\na. araoha mai\nb. kei te aroha au ki a koe\nc. tino pai",
                    "What does \"hangi\" mean in Maori?\na. a traditional Maori feast\nb. a type of clothing\nc. a musical instrument",
                    "How do you say \"please\"in Maori?\na. koa\nb. koauau\nc. whakapaoho",
                    "What does \"waiata\" mean in Maori?\na. story\nb. dance\nc. song",
                    "How do you say \"happy birthday\"in Maori?\na. tamariki\nb. kia tau te rangimarie ki a koe\nc. huritaua ki a koe",
                    "What does \"whenua\" mean in Maori?\na. land\nb. sea\nc. sky",
                    "How do you say \"excuse me\"in Maori\na. ka whai whakaro\nb. he aha te take\nc. whakaaetia ahau",
                    "What does \"puku\" mean in Maori?\na. stomach\nb. head\nc. foot",
                    "How do you say \"thank you\"in Maori\na. haere ra\nb. aroha nui\nc. whakawhetai koe",
                    "What does \"mara\" mean in Maori?\na. garden\nb. beach\nc. mountain"};

                    string[] answer = { "kei te aroha au ki a koe", "a traditional Maori feast", "koa", "song", "huritaua ki a koe", "land", "whakaaetia ahau", "stomach", "whakawhetai koe", "garden" };
                    string[] charAnswer = { "b", "a", "a", "c", "c", "a", "c", "a", "c", "a" };
                    string userInput;

                    //clearing the console, prompting the user what level they selected and adding delays between the messages
                    Console.Clear();
                    Console.WriteLine("You selected the medium level!");
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
                    }//end of for loop
                    if (score <= 3)
                    {
                        Console.WriteLine($"Hard luck your score is {score}");
                    }
                    else if (score <= 6)
                    {
                        Console.WriteLine($"Not to bad your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine($"Great job! Your score is {score}");
                    }
                    //end of levelMedium method 
                }
            
            }
        }
    }
}

