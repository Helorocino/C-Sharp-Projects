using System;

namespace TextBot
{
    class Program
    {
        static void Main(string[] args)
        {

            // change the appearence
            Console.Title = "Texting Bot";
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WindowHeight = 38;
            Console.WindowWidth = 90;

            // start chatting white the bot


            Console.WriteLine("TextBot: Hello, What is your name?");

            // change color

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("        Example : (\"Helorocino\")");
            Console.WriteLine();

            // person type in

            Console.ForegroundColor = ConsoleColor.Yellow;

            string userName = Console.ReadLine();


            // textbot process answer

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.WriteLine("" + userName + ": " + userName);

            // change the color back

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.WriteLine("TextBot: Hmmmmm.... " + userName + " that's a weird name.");
            
            Console.WriteLine("TextBot: Anyway, what color do you like " + userName + "?");
            Console.WriteLine();

            // person type in

            Console.ForegroundColor = ConsoleColor.Yellow;
            string userColor = Console.ReadLine();

            // change color

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.WriteLine( userName +": " + userColor);

            // change the color back and bot type in

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.WriteLine("TextBot: Eeewwwww, " + userColor + " sucks. My fav color is coding. hehheheeheheh");
            Console.WriteLine();

            // coding color

            Console.ForegroundColor = ConsoleColor.Green;

            
            Console.WriteLine("  bit of a color eih.");

            // anyway

            Console.ForegroundColor = ConsoleColor.Gray;

            //bot types in

            Console.WriteLine();
            Console.WriteLine("TextBot: Anyway, have you seen my cat");

            //change color

            Console.ForegroundColor = ConsoleColor.DarkGray;

            //bot type in

            Console.WriteLine("                 (yes or no question)");

            // player color

            Console.ForegroundColor = ConsoleColor.Yellow;

            // player type in yes or no

            Console.WriteLine();
            string userAns = Console.ReadLine();
            Console.WriteLine();

            // person type back

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(userName + ": " + userAns);
            Console.WriteLine();

            //bot change colour


            // change the color to black to make it not visible

            Console.ForegroundColor = ConsoleColor.Black;

            
            // wait before closing

            Console.ReadKey();
        }
    }

}
