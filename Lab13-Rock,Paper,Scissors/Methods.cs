using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    class Methods
    {
        public static void PrintRoshambo(int opponentIndex, List<Player> list1, PlayerUser user)
        {
            Console.WriteLine($"{list1[opponentIndex].Name}: {Enum.GetName(typeof(Roshambo),(list1[opponentIndex].Roshambo))}");
            Console.WriteLine($"{user.Name}: {Enum.GetName(typeof(Roshambo), (user.Roshambo))}");
        }
        public static void CompareRoshambo(List<Player> list, PlayerUser user, int opponentIndex)
        {
            Console.WriteLine("");
            if (list[opponentIndex].Roshambo == user.Roshambo)
            {
                Console.WriteLine("Draw!");
            }
            else if (list[opponentIndex].Roshambo == Roshambo.rock && user.Roshambo == Roshambo.paper)  //rock 0 paper 1
            {
                Console.WriteLine($"{user.Name} wins!");
            }
            else if(list[opponentIndex].Roshambo == Roshambo.rock && user.Roshambo == Roshambo.scissors) //rock 0 scissors 2
            {
                Console.WriteLine($"{list[opponentIndex].Name} wins!");
            }
            else if (list[opponentIndex].Roshambo == Roshambo.paper && user.Roshambo == Roshambo.rock) //paper 1 rock 0
            {
                Console.WriteLine($"{list[opponentIndex].Roshambo} wins!");
            }
            else if(list[opponentIndex].Roshambo== Roshambo.paper && user.Roshambo == Roshambo.scissors) //paper 1 scissors 2
            {
                Console.WriteLine($"{user.Name} wins!");
            }
            else if(list[opponentIndex].Roshambo== Roshambo.scissors && user.Roshambo == Roshambo.rock)//scissors 2 rock 0
            {
                Console.WriteLine($"{user.Name} wins!");
            }
            else if(list[opponentIndex].Roshambo == Roshambo.scissors && user.Roshambo == Roshambo.paper) //scissors 2 paper 1
            {
                Console.WriteLine($"{list[opponentIndex].Name} wins!");
            }
            Console.WriteLine("");
        }
    }
}
