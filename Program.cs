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
            else if (answer == "y")
            {
                Console.WriteLine("Ok, let´s begin");
            }    

            bool playAgain = true;
            int playerscore = 0;
            int computerscore = 0;

            while (playAgain)
            {

                Console.WriteLine("Choose rock, paper or scissor");
                string User = Console.ReadLine();

                Random RPS = new Random();
                int ComputersChoice = RPS.Next(3);

                if (ComputersChoice == 0)
                {
                    if (User == "scissor")
                    {
                     Console.WriteLine("The Computer chose rock.");
                     Console.WriteLine("You chose scissor,so the computer won.");
                     computerscore++;
                    
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
                        playerscore++; 
                    }

                }

                if (ComputersChoice == 1)
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
                        playerscore++; 
                        
                    }

                    else if (User == "paper")
                    {
                        Console.WriteLine("The Computer chose scissor.");
                        Console.WriteLine("And you chose paper, so the computer won.");
                        computerscore++;
                        
                    }

                }

                if (ComputersChoice == 2)
                {
                    if (User == "scissor")
                    {
                        Console.WriteLine("The Computer chose paper.");
                        Console.WriteLine("And you chose scissor, therefore you win.");
                        playerscore++; 
                        
                    }

                    else if (User == "rock")
                    {
                        Console.WriteLine("The Computer chose paper.");
                        Console.WriteLine("And you chose rock, so the computer won.");
                        computerscore++;
                        
                    }

                    else if (User == "paper")
                    {
                        Console.WriteLine("The Computer chose paper.");
                        Console.WriteLine("And you also chose paper, it is a tie.");
                    }

                   
                }
                
                
                Console.WriteLine("Do you want to play again, y/n?");
                string playagainAnswer = Console.ReadLine();
            
                if (playagainAnswer == "y")
                {
                    playAgain=true;
                }

                else 
                {
                    Console.WriteLine("The scores are " +playerscore+ " points for you and " +computerscore+" for the computer."); 
                    if (playerscore > computerscore)
                    {
                        Console.WriteLine("Congratulations. You won!");
                    }

                    else if (playerscore < computerscore)
                    {
                        Console.WriteLine("The computer won, better luck next time");
                    }

                    else 
                    {
                        Console.WriteLine("The game ended with a tie. Good job though!");
                    }
                    
                    Console.WriteLine("Press any key to quit");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }    
            

        
        }
    }    
}

