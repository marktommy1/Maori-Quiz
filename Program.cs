﻿namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = getname();
            play(name);
        }
        static string getname()
        {
            const int maxchar = 30;
            string name;
            bool validateName = true;
            //prompting the user
            Console.WriteLine("Welcome to Mark's Maori Quiz\n");
            //adding a delay between the text
            Thread.Sleep(1000);
            //prompting the user for their name
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            //making sure the user enters a valid name 
            while(validateName == true)
            {
                if (name.Length <= 1)
                {
                    Console.WriteLine("Your name is too short\nPlease enter your name:");
                    name = Console.ReadLine();
                }
                else if (name.Length > maxchar)
                {
                    Console.WriteLine("Your name is too long\nPlease enter your name:");
                    name = Console.ReadLine();
                }
                else if (!name.All(char.IsLetter))
                {
                    Console.WriteLine("Your name can only contain letters\nPlease enter your name:");
                    name = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            //adding a delay between the text
            Thread.Sleep(1000);
            return name;
        //end of getname method
        }
        static void play(string name)
        {
            int score = 0;
            int level = 0;
            string userInput;
            string playAgain;
            bool loop = true;
            //2D array that holds all the questions and answers 
            string[,] questionAnswers = { { "How do you say \"hello\" in Maori?\na. ka kite\nb. noho iho\nc. kia ora", "How do you say \"ocean\" in Maori?\na. moana\nb. awa\nc. katao ", "What does \"haere mai\" mean in Maori?\na. congratulations\nb. go away\nc. come here", "How do you say \"food\" in Maori?\na. waka\nb. ika\nc. kai", "What does \"mahi\" mean in Maori?\na. weclome\nb. work\nc. visitors", "How do you say \"children\" in Maori?\na. tamariki\nb. tamahine\nc. toanga", "What does \"whanau\" mean in Maori?\na. parents\nb. hill\nc. family", "How do you say \"good morning\" in Maori\na. tena koutou\nb. morena\nc. haere ra", "What colour is \"Kowhai\"?\na. blue\nb. red\nc. yellow", "What colour is \"Kikorangi\"?\na. red\nb. blue\nc. orange" }, { "How do you say \"I love you\" in Maori?\na. araoha mai\nb. kei te aroha au ki a koe\nc. tino pai", "What does \"hangi\" mean in Maori?\na. a traditional Maori feast\nb. a type of clothing\nc. a musical instrument", "How do you say \"please\" in Maori?\na. koa\nb. koauau\nc. whakapaoho", "What does \"waiata\" mean in Maori?\na. story\nb. dance\nc. song", "How do you say \"happy birthday\" in Maori?\na. tamariki\nb. kia tau te rangimarie ki a koe\nc. huritaua ki a koe", "What does \"whenua\" mean in Maori?\na. land\nb. sea\nc. sky", "How do you say \"excuse me\" in Maori\na. ka whai whakaro\nb. he aha te take\nc. whakaaetia ahau", "What does \"puku\" mean in Maori?\na. stomach\nb. head\nc. foot", "How do you say \"thank you\" in Maori\na. haere ra\nb. aroha nui\nc. whakawhetai koe", "What does \"mara\" mean in Maori?\na. garden\nb. beach\nc. mountain" }, { "How do you say \"excellence\" in Maori?\na. whakatipu\nb. whakarauora\nc. whakarangatira", "What does \"wairua\" mean in Maori?\na. spirit\nb. body\nc. mind", "How do you say \"sustainability\" in Maori?\na. whakatipu\nb. whakarauora\nc. whakatoputanga", "What does \"tino rangatiratanga\" mean in Maori?\na. self- determination\nb. respect\nc. harmony", "How do you say \"spiritual power\" in Maori?\na. mana tangata\nb. wairua\nc. mauri ora", "What does \"whakawhanaungatanga\" mean in Maori?\na. relationship-building\nb. creativity\nc. persistence", "How do you say \"perfection\" in Maori\na. takakau\nb. whakarewa\nc. whakapau kaha", "What does \"whakapapa\" refer to?\na. land\nb. ancestry\nc. language", "How do you say \"diversity\" in Maori\na. kotahitanga\nb. ahurea rereketanga\nc. whakatairanga", "What does \"manaakitanga\" mean in Maori?\na. hospitality\nb. empowerment\nc. enlightenment" }, { "kia ora", "moana", "come here", "kai", "work", "tamariki", "family", "mornea", "yellow", "blue" }, { "kei te aroha au ki a koe", "a traditional Maori feast", "koa", "song", "huritaua ki a koe", "land", "whakaaetia ahau", "stomach", "whakawhetai koe", "garden" }, { "whakarangatira", "spirit", "whakatoputanga", "self-determination", "wairua", "relationship-building", "takakau", "customary practices", "ahurea rereketanga", "hospitality" }, { "c", "a", "c", "c", "b", "a", "c", "b", "c", "b" }, { "b", "a", "a", "c", "c", "a", "c", "a", "c", "a" }, { "c", "a", "c", "a", "b", "a", "a", "a", "b", "a" } };
            while (loop == true)
            {
                score = 0;
                level = 0;
                Console.WriteLine($"\nHi {name}, please enter what level you would like to play\n1. Easy\n2. Medium\n3. Hard");
                //making sure the user enters a valid level
                while (level != 1 && level != 2 && level != 3)
                {
                    try
                    {
                        level = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid level: ");
                    }
                }
                //clearing the console
                Console.Clear();
                if (level == 1)
                {
                    Console.WriteLine("You selected the easy level!");
                }
                else if (level == 2)
                {
                    Console.WriteLine("You selected the intermediate level!");
                }
                else if (level == 3)
                {
                    Console.WriteLine("You selected the hard level!");
                }
                Thread.Sleep(1000);
                Console.WriteLine("\nGet ready!\n");
                Thread.Sleep(1000);
                //two for loops to get the questions from the 2D array
                for (int i = 0; i < level; i++)
                {
                    for (int j = 0; j < questionAnswers.GetLength(1); j++)
                    {

                        Console.WriteLine($"Question {j + 1}: " + questionAnswers[i, j]);
                        userInput = Console.ReadLine().ToLower();
                        //making sure the user inputs a valid level
                        while(!userInput.Equals("a") && !userInput.Equals("b") && !userInput.Equals("c"))
                        {
                            Console.WriteLine("Please enter a valid answer");
                            userInput = Console.ReadLine().ToLower();
                        }
                        
                        if (userInput.Equals(questionAnswers[level + 5, j]))
                        {
                            score += 1;
                            Console.WriteLine($"Good job {name} you got it right!\nYou're current score is: {score}/{j+1}");
                            Thread.Sleep(1500);
                            Console.Clear();
                        }
                        else
                        {
                            //giving the user a second chance 
                            Console.WriteLine("Try again");
                            userInput = Console.ReadLine().ToLower();
                            while (!userInput.Equals("a") && !userInput.Equals("b") && !userInput.Equals("c"))
                            {
                                Console.WriteLine("Please enter a valid answer");
                                userInput = Console.ReadLine().ToLower();
                            }
                            if (userInput.Equals(questionAnswers[level + 5, j]))
                            {
                                Console.WriteLine($"You got it on your second try. You don't get any points though.\nYour current score is: {score}/{j+1}");
                                Thread.Sleep(2000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"Unlucky, the correct answer was {questionAnswers[level + 2, j]}\nYour current score is: {score}/{j+1}");
                                Thread.Sleep(2300);
                                Console.Clear();
                            }
                        }
                    }
                }//end of for loops
                if (score <= 3)
                {
                    Console.WriteLine($"Hard luck {name} your score is {score}/10");
                }
                else if (score <= 6)
                {
                    Console.WriteLine($"Not to bad {name} your score is {score}/10");
                }
                else
                {
                    Console.WriteLine($"Great job {name}! Your score is {score}/10");
                }   
                Console.WriteLine("Would you like to play again?(y / n)");
                playAgain = Console.ReadLine().ToLower();
                while(!playAgain.Equals("n") && !playAgain.Equals("n"))
                {
                    Console.WriteLine("Please enter a valid input");
                    playAgain = Console.ReadLine().ToLower();
                }
                if(playAgain.Equals("n"))
                {
                    Console.WriteLine("Thanks for playing! See you next time :)");
                    break;
                }
            }//end of while loop 
        }//end of play method
    }
}