using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    class RoshamboApp
    {
        public static void RunRockPaperScissors(int count, PlayerUser user)
        {
            List<Player> opponents = new List<Player>
                    {
                        new PlayerRock(),
                        new PlayerRandom(),
                    };
            int opponentIndex = Validator.ChooseOpponent("Choose your opponent: ", opponents);
            //Validator.ChooseRoshambo(user);
            user.Roshambo = user.GenerateRoshambo();
            Methods.PrintRoshambo(opponentIndex, opponents, user);
            Methods.CompareRoshambo(opponents, user, opponentIndex);
            Console.WriteLine($"You have played {count} game of Rock Paper Scissors!");
        }
    }
}
