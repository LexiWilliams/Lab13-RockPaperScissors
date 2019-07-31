using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Rock_Paper_Scissors
{
    class PlayerRandom :Player
    {
        public static Random random = new Random();

        public PlayerRandom()
        {
            Name = "Hurricane";
            Roshambo = GenerateRoshambo();
        }
        public override Roshambo GenerateRoshambo()
        {
            int index = random.Next(1, 3);
            if (index == 1)
            {
                return Roshambo.rock;
            }
            else if (index == 2)
            {
                return Roshambo.paper;
            }
            else if (index == 3)
            {
                return Roshambo.scissors;
            }
            return GenerateRoshambo();
        }
       
    }
}
