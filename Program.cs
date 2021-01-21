using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this game of Rock, Paper, Scissors.");
            Console.WriteLine("You will play against the computer. I think you know the rules, but if not, here they are...");
            Console.WriteLine("You get to choose if you want to play out the rock, the paper or the scissor.");
            Console.WriteLine("The computer will play any out the objects totally random.");
            Console.WriteLine("Rock wins over scissor, scissor wins over paper, and paper wins over rock.");
            Console.WriteLine("Do you understand, y/n?");
            string answer = Console.ReadLine();

            if (answer == "n")
            {
                Console.WriteLine("Ok, then you should google the rules of this game and then come back. Bye bye!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            else 
            {
                Program.RockPaperScissor();
            }



            Console.ReadKey();
        }

        static void RockPaperScissor() 
        {
            Console.WriteLine("Choose rock, paper or scissor");
            string User = Console.ReadLine();

            Random RPS = new Random();
            int Computer = RPS.Next(3);

            if (Computer == 0)
            {
                if (User == "scissor")
                {
                    Console.WriteLine("The Computer chose rock.");
                    Console.WriteLine("You chose scissor,so the computer won.");
                }

                else if (User == "rock")
                {
                    Console.WriteLine("The Computer chose rock.");
                    Console.WriteLine("And you also chose rock, it is a tie.");
                
                }

                else if (User == "paper")
                {
                    Console.WriteLine("The Computer chose rock.");
                    Console.WriteLine("And you chose paper, therefore you win.");
                }

                else 
                {
                    Console.WriteLine("You didn´t type in any of the choices correctly.");
                    Program.RockPaperScissor();
                }

            }

             if (Computer == 1)
            {
                if (User == "scissor")
                {
                    Console.WriteLine("The Computer chose scissor.");
                    Console.WriteLine("And you also chose scissor, it is a tie.");
                }

                else if (User == "rock")
                {
                    Console.WriteLine("The Computer chose scissor.");
                    Console.WriteLine("And you chose rock, therefore you win.");
                }

                else if (User == "paper")
                {
                    Console.WriteLine("The Computer chose scissor.");
                    Console.WriteLine("And you chose paper, so the computer won.");
                }

                else 
                {
                    Console.WriteLine("You didn´t type in any of the choices correctly.");
                    Program.RockPaperScissor();
                }

            }

            if (Computer == 2)
            {
                if (User == "scissor")
                {
                    Console.WriteLine("The Computer chose paper.");
                    Console.WriteLine("And you chose scissor, therefore you win.");
                }

                else if (User == "rock")
                {
                    Console.WriteLine("The Computer chose paper.");
                    Console.WriteLine("And you chose rock, so the computer won.");
                }

                else if (User == "paper")
                {
                    Console.WriteLine("The Computer chose paper.");
                    Console.WriteLine("And you also chose paper, it is a tie.");
                }

                else 
                {
                    Console.WriteLine("You didn´t type in any of the choices correctly.");
                    Program.RockPaperScissor();
                }
            }
            
            Console.WriteLine("Do you want to play again, y/n?");
            string playagain = Console.ReadLine();
          
            if (playagain == "y")
            {
                 Program.RockPaperScissor();
            }

            else 
            {
                Console.WriteLine("Press any key to quit");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }
    }
}

