using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    enum Roshambo { rock = 1, paper, scissors }
    class Program
    {



        static void Main(string[] args)
        {
            PlayerUser user = new PlayerUser();

            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            string name = Validator.GetName("What is your name? ");
            user.Name = name;
            int count = 0;

            bool playAgain = true;
            while (playAgain)
            {
                count++;
                RoshamboApp.RunRockPaperScissors(count, user);
                playAgain = Validator.PlayAgain("Would you like to play again? yes or no");

            }
        }
    }
}

