using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this game of Rock, Paper, Scissors.");
            Console.WriteLine("You will play against the computer. I think you know the rules, but if not, here they come...");
            Console.WriteLine("You get to choose if you want to play out the rock, the paper or the scissor.");
            Console.WriteLine("The computer will play any out the objects totally random.");
            Console.WriteLine("Rock wins over scissor, scissor wins over paper, and paper wins over rock.")
            Console.WriteLine("Do you understand?");
            string answer = Console.ReadLine();

            if (answer == "NO" || answer == "no" || answer = "No" )
            {
                Console.WriteLine("Ok, then you should google the rules of this game and then come back");
            }



            Console.ReadKey();
        }

        static void RockPaperScissor() 
        {
            Console.WriteLine("Choose Rock, Paper or Scissor. Type in R, P or S");
        }

    }
}
