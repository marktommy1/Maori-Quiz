namespace Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int level = 0;
            Console.WriteLine("Welcome to Mark's Maori Quiz");
            //adding a delay between the text
            Thread.Sleep(1000);
            //prompting the user for their name
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            //adding a delay between the text
            Thread.Sleep(1000);
            //will repeat 
            while(level != 1 || level !=2 || level !=3)
            {
                Console.WriteLine($"Hi {name}, please enter what level you would like to play\n1. Easy\n2. Medium\n3. Hard");
                level = Convert.ToInt32(Console.ReadLine());
            }
            if(level == 1) 
            {
                Console.WriteLine("mark is wrong");
            }

        }
    }
}